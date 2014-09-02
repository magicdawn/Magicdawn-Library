using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Magicdawn.Util
{
    public class Singleton<T>
    {
        static T instance;
        public static T Instance
        {
            get
            {
                //验证instance不可用,重新创建
                if(instance == null)
                {
                    lock(instance)
                    {
                        if(instance == null)
                        {
                            instance = (T)Activator.CreateInstance(typeof(T));
                        }
                    }
                }
                return instance;
            }
        }
    }

    public class Singleton
    {
        static Dictionary<int,object> table = new Dictionary<int,object>();
        public static object GetInstance(Type t)
        {
            var key = t.GetHashCode();
            if(!table.ContainsKey(key) || table[key] == null)
            {
                lock(table)
                {
                    if(!table.ContainsKey(key) || table[key] == null)
                    {
                        var instance = Activator.CreateInstance(t);
                        table.Add(key,instance);
                        return instance;
                    }
                }
            }

            return table[key];
        }
    }
}