using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Magicdawn
{
    //抖动窗口 选项
    /// <summary>
    /// 抖动窗口或控件 的参数 封装
    /// </summary>
    public class ShakeOption
    {
        /// <summary>
        /// 抖动类型
        /// </summary>
        public ShakeType ShakeType { get; set; }//抖动类型
        /// <summary>
        /// 摇动方向
        /// </summary>
        public ShakeDirection ShakeDirection { get; set; }//摇动方向
        /// <summary>
        /// 转动,或者,水平摆动次数
        /// </summary>
        public int Times { get; set; }//转动,或者,水平摆动次数
        /// <summary>
        /// 抖动幅度,半径 or 水平距离
        /// </summary>
        public int Ridus { get; set; }//抖动幅度,半径 or 水平距离

        //构造函数
        /// <summary>
        /// 构造函数,默认circle 默认方向 默认两圈 默认幅度20
        /// </summary>
        public ShakeOption()
        {
            this.ShakeType = ShakeType.Circle;//默认circle
            this.ShakeDirection = ShakeDirection.Default;//默认方向
            this.Times = 2;//
            this.Ridus = 10;//默认幅度20
        }
    }

    //摇动类型
    /// <summary>
    /// 摇动类型
    /// </summary>
    public enum ShakeType
    { 
        /// <summary>
        /// 转圈
        /// </summary>
        Circle=0,
        /// <summary>
        /// 在水平方向上抖动
        /// </summary>
        Horizontal=1//在水平方向上抖动
    }

    //摇动方向
    /// <summary>
    /// 摇动方向
    /// </summary>
    public enum ShakeDirection
    {
        /// <summary>
        /// 默认,circle 逆时针;水平 从左到右
        /// </summary>
        Default=0,//默认,circle 逆时针;水平 从左到右
        /// <summary>
        /// 与默认相反
        /// </summary>
        Reverse=1//与默认相反
    }
}