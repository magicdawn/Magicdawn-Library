// Code are under MIT License
// http://ciconlibrary.codeplex.com/license
// Copyright (c) 2014 Jonathan Magnan. All rights reserved.
// http://www.zzzportal.com
//
// All icons are licensed under a Creative Commons Attribution 3.0 License.
// http://creativecommons.org/licenses/by/3.0/us/
// Copyright 2009-2013 FatCow Web Hosting. All rights reserved.
// http://www.fatcow.com/free-icons

using System.Web.UI;
using System.Web.UI.HtmlControls;

namespace Magicdawn.IconLib
{
    public static class PageExtension
    {
        /// <summary>
        ///     A Page extension method that add the stylesheet to the page header.
        /// </summary>
        /// <param name="this">The @this to act on.</param>
        public static void AddIconStyleSheet(this Page @this)
        {
            var link = new HtmlGenericControl("link");
            link.Attributes.Add("rel", "stylesheet");
            link.Attributes.Add("type", "text/css");
            link.Attributes.Add("href", "z.axd?f=resources.z-icon.css");
            @this.Header.Controls.Add(link);
        }
    }
}