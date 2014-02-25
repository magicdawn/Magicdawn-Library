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
using System.IO;
using System.Linq;
using System.Reflection;
using System.Security.Permissions;
using System.Web;

namespace Magicdawn.IconLib
{
    [AspNetHostingPermission(SecurityAction.LinkDemand, Level = AspNetHostingPermissionLevel.Minimal)]
    public class IconResourceHandler : IHttpHandler
    {
        public static string UniqueName = Guid.NewGuid() + "_";
        public static Assembly Assembly = typeof (Icon).Assembly;

        public void ProcessRequest(HttpContext context)
        {
            if (!IsModified(context))
            {
                SendNotModified(context);
            }
            else
            {
                if (IsValidResourceName(context))
                {
                    string assemblyResourceName = GetAssemblyResourceName(context);
                    string contentType = GetContentType(assemblyResourceName);
                    string cacheName = GetCacheName(assemblyResourceName);
                    byte[] resource = GetFromCache(context, cacheName);
                    if (resource == null)
                    {
                        resource = GetResource(assemblyResourceName);
                        if (resource == null)
                        {
                            // if the resource if invalid
                            return;
                        }
                        AddToCache(context, cacheName, resource);
                    }
                    SetResponseCache(context);
                    SendResource(context, resource, contentType);
                }
            }
        }

        public bool IsReusable
        {
            get { return true; }
        }

        private void SetResponseCache(HttpContext context)
        {
            HttpCachePolicy cache = context.Response.Cache;
            cache.SetLastModified(DateTime.Now.ToUniversalTime().AddSeconds(-1.0));
            cache.SetOmitVaryStar(true);
            cache.SetVaryByCustom("v");
            cache.SetExpires(DateTime.UtcNow.AddDays(365.0));
            cache.SetMaxAge(TimeSpan.FromDays(365.0));
            cache.SetValidUntilExpires(true);
            cache.SetRevalidation(HttpCacheRevalidation.AllCaches);
            cache.SetCacheability(HttpCacheability.Public);
            cache.SetLastModifiedFromFileDependencies();
        }

        public bool IsValidResourceName(HttpContext context)
        {
            return !string.IsNullOrEmpty(context.Request.QueryString["f"]);
        }

        public string GetContentType(string assemblyResourceName)
        {
            string ext = assemblyResourceName.Split('.').Last();
            string type = "";
            if (ext == "js")
            {
                type = "text/javascript";
            }
            else if (ext == "css")
            {
                type = "text/css";
            }
            else if (ext == "gif")
            {
                type = "image/gif";
            }
            else if (ext == "png")
            {
                type = "image/png";
            }
            else if (ext == "jpg" || ext == "jpeg")
            {
                type = "image/jpg";
            }

            return type;
        }

        public bool IsModified(HttpContext context)
        {
            DateTime result;
            DateTime.TryParse(context.Request.Headers["If-Modified-Since"] ?? string.Empty, out result);
            long assemblyTime = File.GetLastWriteTime(new Uri(Assembly.GetName().CodeBase).LocalPath).Ticks;
            DateTime dateAssembly = new DateTime(assemblyTime).ToUniversalTime();
            if (result != DateTime.MinValue && dateAssembly != DateTime.MinValue)
            {
                DateTime dateRequest = result.ToUniversalTime();
                if (dateAssembly > dateRequest && dateAssembly - dateRequest > TimeSpan.FromSeconds(1.0))
                {
                    return true;
                }
            }
            else
            {
                return true;
            }

            return false;
        }

        public void SendNotModified(HttpContext context)
        {
            context.Response.SuppressContent = true;
            context.Response.StatusCode = 304;
            context.Response.StatusDescription = "Not Modified";
            context.Response.AddHeader("Content-Length", "0");
        }

        public string GetAssemblyResourceName(HttpContext context)
        {
            return string.Concat("Magicdawn.IconLib.", context.Request.QueryString["f"]);
        }

        public string GetCacheName(string assemblyResourceName)
        {
            return UniqueName + assemblyResourceName;
        }

        public byte[] GetFromCache(HttpContext context, string cacheName)
        {
            return (byte[]) context.Cache[cacheName];
        }

        public byte[] GetResource(string assemblyResourceName)
        {
            using (Stream stream = Assembly.GetManifestResourceStream(assemblyResourceName))
            {
                if (stream != null)
                {
                    int length = Convert.ToInt32(stream.Length);
                    var output = new byte[length];
                    stream.Read(output, 0, length);
                    return output;
                }
            }
            return null;
        }

        public void AddToCache(HttpContext context, string cacheName, byte[] resource)
        {
            context.Cache[cacheName] = resource;
        }

        public void SendResource(HttpContext context, byte[] resource, string resourceType)
        {
            HttpResponse response = context.Response;
            response.Charset = "utf-8";
            response.ContentType = resourceType;
            response.BinaryWrite(resource);
        }
    }
}