using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace Magicdawn
{
    /// <summary>
    /// Graphics.DrawCoordinate所用到的Option
    /// </summary>
    public class CoordinateOption
    {
        ////x,y轴
        //var axisPen = option.AxisPen;//x y轴的Pen
        //var x = option.X;
        //var y = option.Y;
        //var fx = option.Fx;
        //var fy = option.Fy;
        public Pen AxisPen { get; set; }
        public int X { get; set; }
        public int Y { get; set; }
        public int Fx { get; set; }
        public int Fy { get; set; }

        ////文字
        //var stringPen = option.StringPen;//string pen
        //var stringFont = option.StringFont;//文字字体
        ////文字高度不让定制
        public Brush StringBrush { get; set; }
        public Font StringFont { get; set; }

        ////圆心
        //var centerBrush = option.CenterBrush;//圆心Brush
        //var centerRidus = option.CenterRadius;//原点 圆半径
        public Brush CenterBrush { get; set; }
        public int CenterRadius { get; set; }

        ////小箭头,小三角
        //var arrowBrush = option.ArrowBrush;//小箭头Brush
        //int arrowHeight = 5;//小三角高度
        public Brush ArrowBrush { get; set; }
        public int ArrowHeight { get; set; }

        public CoordinateOption()
        {
            //默认 红色 1px,-100 至 100
            this.AxisPen = new Pen(Brushes.Red, 1);
            this.X = 100;
            this.Y = 100;
            this.Fx = -100;
            this.Fy = -100;

            //文字,黑色
            this.StringBrush = Brushes.Black;
            this.StringFont = new Font("微软雅黑", 10.5f);

            //原点处小圆
            this.CenterBrush = Brushes.Red;
            this.CenterRadius = 5;

            //小箭头
            this.ArrowBrush = Brushes.Red;
            this.ArrowHeight = 5;
        }
    }
}
