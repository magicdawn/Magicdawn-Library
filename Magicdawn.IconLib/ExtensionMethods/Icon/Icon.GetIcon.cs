// Code are under MIT License
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
using System.Drawing;
using System.IO;
using System.Reflection;
using System.Runtime.InteropServices;

public static partial class IconExtension
{
    [DllImport("user32.dll", CharSet = CharSet.Auto)]
    private static extern bool DestroyIcon(IntPtr handle);

    /// <summary>
    ///     An Icon extension method that get the 16x16 Icon.
    /// </summary>
    /// <param name="this">The @this to act on.</param>
    /// <returns>The 16x16 Icon.</returns>
    public static Icon GetIcon16(this  Magicdawn.IconLib.Icon @this)
    {
        Type t = typeof(Magicdawn.IconLib.Icon);
        Assembly assembly = t.Assembly;
        FieldInfo fi = t.GetField(@this.ToString());
        var attributes = (DescriptionAttribute[])fi.GetCustomAttributes(typeof(DescriptionAttribute), false);

        if (attributes.Length > 0)
        {
            string path = attributes[0].Description;
            string assemblyResourceName = "Magicdawn.IconLib.Icon16." + path;
            using (Stream stream = assembly.GetManifestResourceStream(assemblyResourceName))
            {
                if (stream != null)
                {
                    using (var bitmap = new Bitmap(stream))
                    {
                        IntPtr intPtr = bitmap.GetHicon();
                        using (var iconHandle = Icon.FromHandle(intPtr))
                        {
                            var icon = new Icon(iconHandle, iconHandle.Width, iconHandle.Height);
                            DestroyIcon(intPtr);
                            return icon;
                        }
                    }
                }
                else
                {
                    return null;
                }
            }
        }
        return null;
    }

    /// <summary>
    ///     An Icon extension method that get the 32x32 Icon.
    /// </summary>
    /// <param name="this">The @this to act on.</param>
    /// <returns>The 32x32 Icon.</returns>
    public static Icon GetIcon32(this Magicdawn.IconLib.Icon @this)
    {
        Type enumType = typeof(Magicdawn.IconLib.Icon);
        Assembly assembly = enumType.Assembly;
        FieldInfo fi = enumType.GetField(@this.ToString());
        var attributes = (DescriptionAttribute[])fi.GetCustomAttributes(typeof(DescriptionAttribute), false);

        if (attributes.Length > 0)
        {
            string path = attributes[0].Description;
            string assemblyResourceName = "Magicdawn.IconLib.Icon32." + path;

            using (Stream stream = assembly.GetManifestResourceStream(assemblyResourceName))
            {
                if (stream != null)
                {
                    using (var bitmap = new Bitmap(stream))
                    {
                        IntPtr intPtr = bitmap.GetHicon();
                        using (var iconHandle = Icon.FromHandle(intPtr))
                        {
                            var icon = new Icon(iconHandle, iconHandle.Width, iconHandle.Height);
                            DestroyIcon(intPtr);
                            return icon;
                        }
                    }
                }
                else
                {
                    return null;
                }
            }
        }
        return null;
    }
}