using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using System.Diagnostics;
using System.Threading.Tasks;

/*
 * 2014-2-17 17:18:17
 * 
 * 根据以前的WinQuery改编过来,
 * 增加同步(sync)方法,是为了能够连续操作
 * 如Task.Run(()=>{
 *      slide-left-sync()啊
 *      slide-right-sync() slideleft没完成不会slideright的
 * })
 * 
 * BY  Magicdawn
 */

namespace Magicdawn
{
    public class AnimateHelper
    {
        /// <summary>
        /// 动画间隔13ms根据jquery而来
        /// </summary>
        public const int AnimationInterval = 13;

        //抖动窗口控件
        /// <summary>
        /// 抖动窗口控件
        /// </summary>
        /// <param name="ctl">要操作的控件</param>
        /// <param name="Option">抖动时的一些参数封装</param>
        public static void Shake(Control ctl, ShakeOption Option = null)
        {
            //Shake代码实现
            #region 我写的版本,网上再找找
            //判断,是否传递了ShakeOptions
            if (Option == null)
            {
                Option = new ShakeOption();
            }

            //开启新线程 抖动 控件
            new Thread(() => {
                var old = ctl.Location;//保存原来位置

                //一些系数
                //默认转圈,转圈1 水平0,乘到y里面
                int fType = Option.ShakeType == ShakeType.Circle ? 1 : 0;
                //默认逆时针,1 ;顺时针-1乘到角度里面去
                int fDir = Option.ShakeDirection == ShakeDirection.Default ? 1 : -1;

                //改变Location
                for (int i = 0; i < Option.Times; i++)//按Options确定圈数或者水平次数
                {
                    for (double j = 0; j < 2 * Math.PI; j += 0.1)
                    {
                        ctl.Invoke((Action)(() => {
                            ctl.Location = new Point(
                                old.X + (int)(Math.Cos(j * fDir) * Option.Ridus),
                                old.Y + (int)(Math.Sin(j * fDir) * Option.Ridus * fType));
                        }));
                        Thread.Sleep(3);
                    }
                }
                //恢复
                ctl.Invoke(new Action(() => {
                    ctl.Location = old;
                }));
            }) { IsBackground = true }.Start();
            #endregion
        }

        //仿Jq动画
        /// <summary>
        /// 仿Jq动画
        /// </summary>
        /// <param name="ctl">要操作的控件</param>
        /// <param name="Option">动画的一些参数封装,必须提供</param>
        public static void Animate(Control ctl, AnimateOption Option)
        {
            var oldLocation = ctl.Location;
            var oldX = ctl.Location.X;
            var oldY = ctl.Location.Y;

            var newX = Option.X == 0 ? oldX : Option.X;
            var newY = Option.Y == 0 ? oldY : Option.Y;

            double stepX = (newX - oldX) * 13d / Option.Speed;
            double stepY = (newY - oldY) * 13d / Option.Speed;

            double currentX = oldX;
            double currentY = oldY;
            //通过 一段时间 把Location old->new
            new Thread(() => {
                var timer = new System.Threading.Timer(state => {
                    currentX += stepX;
                    currentY += stepY;
                    ctl.Invoke(new Action(() => {
                        ctl.Location = new Point((int)currentX, (int)currentY);
                    }));
                }, null, 0, AnimationInterval);//Jquery 13ms

                Thread.Sleep(Option.Speed + 40);//运行这么长时间,然后关掉timer
                timer.Dispose();
                ctl.Invoke(new Action(() => {
                    ctl.Location = new Point(newX, newY);
                }));
            }) { IsBackground = true }.Start();
        }
        //阻塞线程的
        /// <summary>
        /// 阻塞线程的Sync动画方法
        /// </summary>
        /// <param name="ctl">要操作的控件</param>
        /// <param name="Option">动画的一些参数封装,必须提供</param>
        public static void AnimateSync(Control ctl, AnimateOption Option)
        {
            var oldLocation = ctl.Location;
            var oldX = ctl.Location.X;
            var oldY = ctl.Location.Y;

            var newX = Option.X == 0 ? oldX : Option.X;
            var newY = Option.Y == 0 ? oldY : Option.Y;

            double stepX = (newX - oldX) * 13d / Option.Speed;
            double stepY = (newY - oldY) * 13d / Option.Speed;

            double currentX = oldX;
            double currentY = oldY;
            //通过 一段时间 把Location old->new
                var timer = new System.Threading.Timer(state => {
                    currentX += stepX;
                    currentY += stepY;
                    ctl.Invoke(new Action(() => {
                        ctl.Location = new Point((int)currentX, (int)currentY);
                    }));
                }, null, 0, AnimationInterval);//Jquery 13ms

                Thread.Sleep(Option.Speed + 40);//运行这么长时间,然后关掉timer
                timer.Dispose();
                ctl.Invoke(new Action(() => {
                    ctl.Location = new Point(newX, newY);
                }));
        }

        //slide
        /// <summary>
        /// 将控件从窗体左侧滑进
        /// </summary>
        /// <param name="ctl">控件</param>
        /// <param name="speed">动画维持时间</param>
        public static void SlideLeft(Control ctl, int speed = 300)
        {
            var original = ctl.Location;
            ctl.Location = new Point(0 - ctl.Width, ctl.Location.Y);
            ctl.Show();
            AnimateHelper.Animate(ctl, new AnimateOption {
                X = original.X,
                Speed = speed
            });
        }
        /// <summary>
        /// 将控件从窗体右侧滑进
        /// </summary>
        /// <param name="ctl">控件</param>
        /// <param name="speed">动画维持时间</param>
        public static void SlideRight(Control ctl, int speed = 300)
        {
            var original = ctl.Location;
            ctl.Location = new Point(ctl.FindForm().Width, ctl.Location.Y);
            ctl.Show();
            AnimateHelper.Animate(ctl, new AnimateOption {
                X = original.X,
                Speed = speed
            });
        }
        /// <summary>
        /// 将控件从窗体顶部滑进
        /// </summary>
        /// <param name="ctl">控件</param>
        /// <param name="speed">动画维持时间</param>
        public static void SlideTop(Control ctl, int speed = 300)
        {
            var original = ctl.Location;
            ctl.Location = new Point(ctl.Location.X, 0 - ctl.Height);
            ctl.Show();
            AnimateHelper.Animate(ctl, new AnimateOption {
                Y = original.Y,
                Speed = speed
            });
        }
        /// <summary>
        /// 将控件从窗体底部滑进
        /// </summary>
        /// <param name="ctl">控件</param>
        /// <param name="speed">动画维持时间</param>
        public static void SlideBottom(Control ctl, int speed = 300)
        {
            var original = ctl.Location;
            ctl.Location = new Point(ctl.Location.X, ctl.FindForm().Height);
            ctl.Show();
            AnimateHelper.Animate(ctl, new AnimateOption {
                Y = original.Y,
                Speed = speed
            });
        }
        //窗体从屏幕上方slide
        /// <summary>
        /// 窗体从屏幕上方slide
        /// </summary>
        /// <param name="frm">窗体</param>
        /// <param name="speed">动画维持时间</param>
        public static void SlideForm(Form frm, int speed = 300)
        {
            frm.GetAllControls().ForEach(c => c.Hide());//隐藏控件
            var original = frm.Location;
            frm.Location = new Point(frm.Location.X, -frm.Height);
            AnimateHelper.Animate(frm, new AnimateOption {
                Y = original.Y,
                Speed = speed
            });
        }

        //slide阻塞
        /// <summary>
        /// 将控件从窗体左侧滑进,该方法为阻塞线程
        /// </summary>
        /// <param name="ctl">控件</param>
        /// <param name="speed">动画维持时间</param>
        public static void SlideLeftSync(Control ctl, int speed = 300)
        {
            var original = ctl.Location;
            ctl.Location = new Point(0 - ctl.Width, ctl.Location.Y);
            ctl.Show();
            AnimateHelper.AnimateSync(ctl, new AnimateOption {
                X = original.X,
                Speed = speed
            });
        }
        /// <summary>
        /// 将控件从窗体右侧滑进,该方法为阻塞线程
        /// </summary>
        /// <param name="ctl">控件</param>
        /// <param name="speed">动画维持时间</param>
        public static void SlideRightSync(Control ctl, int speed = 300)
        {
            var original = ctl.Location;
            ctl.Location = new Point(ctl.FindForm().Width, ctl.Location.Y);
            ctl.Show();
            AnimateHelper.AnimateSync(ctl, new AnimateOption {
                X = original.X,
                Speed = speed
            });
        }
        /// <summary>
        /// 将控件从窗体顶部滑进,该方法为阻塞线程
        /// </summary>
        /// <param name="ctl">控件</param>
        /// <param name="speed">动画维持时间</param>
        public static void SlideTopSync(Control ctl, int speed = 300)
        {
            var original = ctl.Location;
            ctl.Location = new Point(ctl.Location.X, 0 - ctl.Height);
            ctl.Show();
            AnimateHelper.AnimateSync(ctl, new AnimateOption {
                Y = original.Y,
                Speed = speed
            });
        }
        /// <summary>
        /// 将控件从窗体底部滑进,该方法为阻塞线程
        /// </summary>
        /// <param name="ctl">控件</param>
        /// <param name="speed">动画维持时间</param>
        public static void SlideBottomSync(Control ctl, int speed = 300)
        {
            var original = ctl.Location;
            ctl.Location = new Point(ctl.Location.X, ctl.FindForm().Height);
            ctl.Show();
            AnimateHelper.AnimateSync(ctl, new AnimateOption {
                Y = original.Y,
                Speed = speed
            });
        }
        //窗体从上方slide
        /// <summary>
        /// 窗体从屏幕顶部slide,该方法会阻塞调用线程
        /// </summary>
        /// <param name="frm"></param>
        /// <param name="speed"></param>
        public static void SlideFormSync(Form frm, int speed = 300)
        {
            frm.GetAllControls().ForEach(c => c.Hide());//隐藏控件
            var original = frm.Location;
            frm.Location = new Point(frm.Location.X, -frm.Height);
            AnimateHelper.AnimateSync(frm, new AnimateOption {
                Y = original.Y,
                Speed = speed
            });
        }
    }
}
