using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Magicdawn.Util
{
    public class MyStringBuilder : IDisposable
    {
        public StringBuilder Sb { get; set; }
        public MyStringBuilder()
        {
            this.Sb = new StringBuilder();
        }
        ~MyStringBuilder()
        {
            Dispose(false);
        }


        public static MyStringBuilder operator +(MyStringBuilder mySb,string str)
        {
            mySb.Sb.Append(str);
            return mySb;
        }
        public override string ToString()
        {
            return this.Sb.ToString();
        }


        public void Dispose()
        {
            Dispose(true);
        }
        public virtual void Dispose(bool disposing)
        {
            if(disposing)
            {
                //显式调用dispose
                Sb = null;
            }
        }
    }
}