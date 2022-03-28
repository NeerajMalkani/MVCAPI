using System;
using System.IO;
using System.Web;
using System.Web.Caching;
using System.Web.Http;
using System.Web.Mvc;
using TrepupAPI.Configuration;

namespace TrepupAPI
{
    public class Global : HttpApplication
    {
        protected void Application_Start(object sender, EventArgs e)
        {
            AreaRegistration.RegisterAllAreas();
            GlobalConfiguration.Configure(TrepupAPIConfig.Register);

            RemoveTemporaryFiles();
            RemoveTemporaryFilesSchedule();
        }

        public void RemoveTemporaryFiles()
        {
            string pathTemp = HttpContext.Current.Server.MapPath("~") + "Images";

            if ((pathTemp.Length > 0) && (Directory.Exists(pathTemp)))
            {
                foreach (string folders in Directory.GetDirectories(pathTemp))
                {
                    try
                    {
                        DirectoryInfo directoryInfo = new DirectoryInfo(folders);
                        //FileInfo fi = new FileInfo(file);
                        if (directoryInfo.CreationTime < DateTime.Now.AddHours(-48))
                        {
                            directoryInfo.Delete(true);
                        }
                    }
                    catch (Exception) { }
                }
            }
        }

        public void RemoveTemporaryFilesSchedule()
        {
            HttpRuntime.Cache.Insert("RemoveTemporaryFiles", string.Empty, null, DateTime.Now.AddHours(24), Cache.NoSlidingExpiration, CacheItemPriority.NotRemovable, delegate (string id, object o, CacheItemRemovedReason cirr)
            {
                if (id.Equals("RemoveTemporaryFiles", StringComparison.OrdinalIgnoreCase))
                {
                    RemoveTemporaryFiles();
                    RemoveTemporaryFilesSchedule();
                }
            });
        }

        protected void Session_Start(object sender, EventArgs e)
        {
        }

        protected void Application_BeginRequest(object sender, EventArgs e)
        {
            //HttpContext.Current.Response.AddHeader("Access-Control-Allow-Origin", "*");
            //if (HttpContext.Current.Request.HttpMethod == "OPTIONS")
            //{
            //    HttpContext.Current.Response.AddHeader("Cache-Control", "no-cache");
            //    HttpContext.Current.Response.AddHeader("Access-Control-Allow-Methods", "GET, POST, PUT, DELETE");
            //    HttpContext.Current.Response.AddHeader("Access-Control-Allow-Headers", "Content-Type, Accept");
            //    HttpContext.Current.Response.AddHeader("Access-Control-Max-Age", "1728000");
            //    HttpContext.Current.Response.End();
            //}

            //if (HttpContext.Current.Request.HttpMethod == "OPTIONS")
            //{
            //    HttpContext.Current.Response.Flush();
            //}
        }

        protected void Application_AuthenticateRequest(object sender, EventArgs e)
        {
        }

        protected void Application_Error(object sender, EventArgs e)
        {
        }

        protected void Session_End(object sender, EventArgs e)
        {
        }

        protected void Application_End(object sender, EventArgs e)
        {
        }
    }
}