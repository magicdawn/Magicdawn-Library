using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
public static class PointExtension
{
    //将点平移得到新点,加法
    /// <summary>
    /// Point加法,向右下角平移
    /// </summary>
    /// <param name="originalPoint">原始点</param>
    /// <param name="p2Add">要加上的点</param>
    /// <returns>结果</returns>
    public static Point Add(this Point originalPoint,Point p2Add)
    {
        return new Point(originalPoint.X + p2Add.X,
            originalPoint.Y + p2Add.Y);
    }
    public static Point Add(this Point originalPoint,int p2AddX,int p2AddY)
    {
        return originalPoint.Add(new Point(p2AddX,p2AddY));
    }

    //X改变
    public static Point AddX(this Point originalPoint,int X)
    {
        return originalPoint.Add(X,0);
    }
    //Y改变
    public static Point AddY(this Point originalPoint,int Y)
    {
        return originalPoint.Add(0,Y);
    }

    //减去,向左上角平移
    /// <summary>
    /// 减去,向左上角平移
    /// </summary>
    /// <param name="originalPoint">原始点</param>
    /// <param name="p2Minus">要加上的点</param>
    /// <returns>结果</returns>
    public static Point Minus(this Point originalPoint,Point p2Minus)
    {
        return new Point(originalPoint.X - p2Minus.X,
            originalPoint.Y - p2Minus.Y);
    }
    public static Point Minus(this Point originalPoint,int p2MinusX,int p2MinusY)
    {
        return originalPoint.Minus(new Point(p2MinusX,p2MinusY));
    }

    //X Y变为相反数
    /// <summary>
    /// X Y变为相反数
    /// </summary>
    /// <param name="originalPoint">原始点</param>
    /// <returns>结果</returns>
    public static Point Reverse(this Point originalPoint)
    {
        return new Point(-originalPoint.X,-originalPoint.Y);
    }
}