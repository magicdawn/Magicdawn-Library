using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Magicdawn.Util
{
    public class StringFinder
    {
        /// <summary>
        /// 找另一个符号在template中的位置
        /// </summary>
        /// <param name="template"></param>
        /// <param name="firstIndex"></param>
        /// <returns></returns>
        public static int GetSecondIndex(string template,int firstIndex = 0)
        {
            var pairs = new Dictionary<char,char>()
            { 
                { '{','}' },
                { '(',')' },
                { '[',']' }
            };

            var count = 1;
            var first = template[firstIndex];
            var second = pairs[first];

            for(int index = firstIndex + 1;index < template.Length;index++)
            {
                var cur = template[index];
                if(cur == second)
                {
                    count--;
                    if(count == 0)
                    {
                        return index;
                    }
                }
                else if(cur == first)
                {
                    count++;
                }
            }

            return -1; //没找到
        }
    }
}
