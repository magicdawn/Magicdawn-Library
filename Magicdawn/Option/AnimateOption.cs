using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Magicdawn
{
    /// <summary>
    /// 仿Jq动画,方法的参数,封装
    /// </summary>
    public class AnimateOption//动画 选项
    {
        /// <summary>
        /// 要运动到的X坐标
        /// </summary>
        public int X { get; set; }//要运动到的X坐标
        /// <summary>
        /// 要运动到的Y坐标
        /// </summary>
        public int Y { get; set; }//要运动到的Y坐标
        /// <summary>
        /// 毫秒数,运动快慢
        /// </summary>
        public int Speed { get; set; }//毫秒数,运动快慢
        /// <summary>
        /// 可以用fast=200 normal=400 slow=200来控制,与设置Speed效果相同,同时设置,后设置的生效
        /// </summary>
        public string SpeedX
        {
            set
            {
                switch (value)
                {
                    case "fast":
                        Speed = 200;
                        break;
                    case "normal":
                        Speed = 400;
                        break;
                    case "slow":
                        Speed = 600;
                        break;
                    default:
                        Speed = 200;//默认为fast
                        break;
                }
            }
        }//可以用fast=200 normal=400 slow=200来控制,与设置Speed效果相同,同时设置,后设置的生效
    }
}
