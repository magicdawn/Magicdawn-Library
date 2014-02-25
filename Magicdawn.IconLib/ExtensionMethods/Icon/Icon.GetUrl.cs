/// Code are under MIT License
// http://ciconlibrary.codeplex.com/license
// Copyright (c) 2014 Jonathan Magnan. All rights reserved.
// http://www.zzzportal.com
//
// All icons are licensed under a Creative Commons Attribution 3.0 License.
// http://creativecommons.org/licenses/by/3.0/us/
// Copyright 2009-2013 FatCow Web Hosting. All rights reserved.
// http://www.fatcow.com/free-icons

using System;
using System.ComponentModel;
using System.Reflection;

public static partial class IconExtension
{
    /// <summary>
    ///     An Icon extension method that gets URL to use with the IconResourceHandler for the 16x16 icon.
    /// </summary>
    /// <param name="this">The @this to act on.</param>
    /// <returns>The URL to use with the IconResourceHanler for the 16x16 icon.</returns>
    public static string GetUrl16(this Magicdawn.IconLib.Icon @this)
    {
        Type enumType = typeof (Magicdawn.IconLib.Icon);
        FieldInfo fi = enumType.GetField(@this.ToString());
        var attributes = (DescriptionAttribute[]) fi.GetCustomAttributes(typeof (DescriptionAttribute), false);

        if (attributes.Length > 0)
        {
            return "z.axd?f=Icon16." + attributes[0].Description;
        }
        return null;
    }

    /// <summary>
    ///     An Icon extension method that gets URL to use with the IconResourceHandler for the 32x32 icon.
    /// </summary>
    /// <param name="this">The @this to act on.</param>
    /// <returns>The URL to use with the IconResourceHanler for the 32x32 icon.</returns>
    public static string GetUrl32(this Magicdawn.IconLib.Icon @this)
    {
        Type enumType = typeof (Magicdawn.IconLib.Icon);
        FieldInfo fi = enumType.GetField(@this.ToString());
        var attributes = (DescriptionAttribute[]) fi.GetCustomAttributes(typeof (DescriptionAttribute), false);

        if (attributes.Length > 0)
        {
            return "z.axd?f=Icon32." + attributes[0].Description;
        }
        return null;
    }
}