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
using System.IO;
using System.Reflection;
using Magicdawn.IconLib;

public static partial class IconExtension
{
    /// <summary>
    ///     An Icon extension method that get the 16x16 icon as Stream.
    /// </summary>
    /// <param name="this">The @this to act on.</param>
    /// <returns>The 16x16 icon as Stream.</returns>
    public static Stream GetStream16(this Icon @this)
    {
        Type enumType = typeof(Icon);
        Assembly assembly = enumType.Assembly;
        FieldInfo fi = enumType.GetField(@this.ToString());
        var attributes = (DescriptionAttribute[])fi.GetCustomAttributes(typeof(DescriptionAttribute), false);

        if (attributes.Length > 0)
        {
            string path = attributes[0].Description;
            string assemblyResourceName = "Magicdawn.IconLib.Icon16." + path;

            return assembly.GetManifestResourceStream(assemblyResourceName);
        }
        return null;
    }

    /// <summary>
    ///     An Icon extension method that get the 32x32 icon as Stream.
    /// </summary>
    /// <param name="this">The @this to act on.</param>
    /// <returns>The 16x16 icon as Stream.</returns>
    public static Stream GetStream32(this Icon @this)
    {
        Type enumType = typeof(Icon);
        Assembly assembly = enumType.Assembly;
        FieldInfo fi = enumType.GetField(@this.ToString());
        var attributes = (DescriptionAttribute[])fi.GetCustomAttributes(typeof(DescriptionAttribute), false);

        if (attributes.Length > 0)
        {
            string path = attributes[0].Description;
            string assemblyResourceName = "Magicdawn.IconLib.Icon32." + path;

            return assembly.GetManifestResourceStream(assemblyResourceName);
        }
        return null;
    }
}