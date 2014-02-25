// Code are under MIT License
// http://ciconlibrary.codeplex.com/license
// Copyright (c) 2014 Jonathan Magnan. All rights reserved.
// http://www.zzzportal.com
//
// All icons are licensed under a Creative Commons Attribution 3.0 License.
// http://creativecommons.org/licenses/by/3.0/us/
// Copyright 2009-2013 FatCow Web Hosting. All rights reserved.
// http://www.fatcow.com/free-icons

public static partial class IconExtension
{
    /// <summary>
    ///     An Icon extension method that get the stylesheet css class for the 16x16 icon.
    /// </summary>
    /// <param name="this">The @this to act on.</param>
    /// <returns>The stylesheet css class for the 16x16 icon.</returns>
    public static string GetCssClass16(this Magicdawn.IconLib.Icon @this)
    {
        return string.Concat("Icon16_", @this.ToString());
    }

    /// <summary>
    ///     An Icon extension method that get the stylesheet css class for the 32x32 icon.
    /// </summary>
    /// <param name="this">The @this to act on.</param>
    /// <returns>The stylesheet css class for the 32x32 icon.</returns>
    public static string GetCssClass32(this Magicdawn.IconLib.Icon @this)
    {
        return string.Concat("Icon32_", @this.ToString());
    }
}