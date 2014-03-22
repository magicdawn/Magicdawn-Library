using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Magicdawn.Util
{
    /// <summary>
    /// 单例模式,类
    /// 由于扩展了Validator,Creator等,将Instance属性改为GetInstance方法
    /// </summary>
    /// <typeparam name="T">要获取单例的类型</typeparam>
    public class Singleton<T>
    {
        //私有字段
        private static T instance;
        //默认验证器
        private static Func<T,bool> defaultValidator = instance => (instance != null);
        //默认构建器
        private static Func<T> defaultCreator = () => (T)(Activator.CreateInstance(typeof(T)));

        //检查instance是否有效
        static bool ValidateInstance(T instance,Func<T,bool> validator)
        {
            //先验证是否为null
            bool res = defaultValidator(instance);
            //再调用自定义validator验证
            if(validator != null)
            {
                //如果res已经是false,即instance=null,就不判断这个validator了
                //&& 有短路功能
                res = res && validator(instance);
            }
            return res;
        }

        //创建实例
        static T CreateInstance(Func<T> creator = null)
        {
            if(creator != null)
            {
                //自定义 创建器
                return creator();
            }
            return defaultCreator();
        }

        //获取实例
        /// <summary>
        /// 获取实例
        /// </summary>
        /// <param name="validator">自定义验证器</param>
        /// <param name="creator">自定义构造器</param>
        /// <returns>单例</returns>
        public static T GetInstance(Func<T,bool> validator = null,Func<T> creator = null)
        {
            //验证instance不可用,重新创建
            if(!ValidateInstance(instance,validator))
            {
                instance = CreateInstance(creator);
            }
            return instance;
        }
    }

    /// <summary>
    /// 预定义的验证器
    /// 有些类的实例,虽然不为null,但是已经不能使用,如Dispose过的Form
    /// </summary>
    public static class SingletonValidators
    {
        /// <summary>
        /// 用于WinForm的验证器,如果没有Disposed表示实例还可用
        /// </summary>
        public static Func<Form,bool> FormValidator = frm => !frm.IsDisposed;
    }

    /// <summary>
    /// 预定义的构造器
    /// </summary>
    public static class SingletonCreators
    {
        //public static Func<T> xxxCreator=xxx;
    }
}

/*
 * 例如你要打开一个窗口
 * Singleton<FrmMain>.GetInstance(SingletonValidators.FormValidator).Show();
 * 
 * 即可保证只打开一个窗口
 * 
 * 在GetInstance方法中
 *  第一个参数,指定instance可不可以用
 *  第二个参数,可以自定义 构造函数,默认的是用Activtor.CreateInstance(typeof(T))构建的
 *      只要返回值是Singleton<T>那个T类型就好
*/