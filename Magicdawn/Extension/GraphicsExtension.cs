using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using Magicdawn;
/// <summary>
/// 扩充System.Drawing.Graphics类
/// </summary>
public static class GraphicsExtension
{
    //画出坐标系,Coordinate坐标,fx:-x
    /// <summary>
    /// 在g的原点处画坐标系
    /// </summary>
    /// <param name="g"></param>
    /// <param name="option"></param>
    public static void DrawCoordinate(this Graphics g,CoordinateOption option = null)
    {
        if(option == null)
        {
            option = new CoordinateOption();//提供默认值
        }

        //x,y轴
        var axisPen = option.AxisPen;//x y轴的Pen
        var x = option.X;
        var y = option.Y;
        var fx = option.Fx;
        var fy = option.Fy;

        //文字
        var stringBrush = option.StringBrush;//string pen
        var stringFont = option.StringFont;//文字字体
        //文字高度不让定制

        //圆心
        var centerBrush = option.CenterBrush;//圆心Brush
        var centerRidus = option.CenterRadius;//原点 圆半径

        //小箭头,小三角
        var arrowBrush = option.ArrowBrush;//小箭头Brush
        int arrowHeight = option.ArrowHeight;//小三角高度

        //X轴 文字 三角
        g.DrawLine(axisPen,fx,0,x,0);//x axis
        g.DrawString("X轴",stringFont,stringBrush,x + 5,-18 / 2);
        g.FillPolygon(arrowBrush,new Point[] { 
                new Point(x,0-arrowHeight),
                new Point(x,0+arrowHeight),
                new Point(x+arrowHeight,0)
            });

        g.DrawLine(axisPen,0,fy,0,y);//y axis
        g.DrawString("Y轴",stringFont,stringBrush,0 - 25 / 2,y + 5);
        g.FillPolygon(arrowBrush,new Point[]{
                new Point(-arrowHeight,y),
                new Point(arrowHeight,y),
                new Point(0,y+arrowHeight)
            });

        g.FillCircle(centerBrush,0,0,centerRidus);//(0,0) Point
    }

    //画圆
    /// <summary>
    /// 画圆,参数对应Graphics.DrawEllipse的参数
    /// </summary>
    /// <param name="g">画笔</param>
    /// <param name="pen">Pen</param>
    /// <param name="centerX">圆心X</param>
    /// <param name="centerY">圆心Y</param>
    /// <param name="ridus">半径</param>
    public static void DrawCircle(this Graphics g,Pen pen,
        int centerX,int centerY,int ridus)
    {
        g.DrawEllipse(pen,centerX - ridus,centerY - ridus,ridus,ridus);
    }

    //填充圆
    /// <summary>
    /// 填充圆
    /// </summary>
    /// <param name="g">画笔</param>
    /// <param name="brush">brush</param>
    /// <param name="centerX">圆心X</param>
    /// <param name="centerY">圆心Y</param>
    /// <param name="ridus">半径</param>
    public static void FillCircle(this Graphics g,Brush brush,
        int centerX,int centerY,int ridus)
    {
        g.FillEllipse(brush,centerX - ridus,centerY - ridus,ridus * 2,ridus * 2);
    }
}