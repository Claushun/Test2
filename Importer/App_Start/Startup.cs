using Microsoft.Owin;
using Microsoft.Owin.Security.Cookies;
using Owin;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;


namespace Importer.App_Start
{
    public class Startup
    {
        public void Configuration(IAppBuilder app) // IAppBuilder object that serves as the entry point to the pipeline. Serves as the linking of the pipeline branches
        {
            app.UseCookieAuthentication(new CookieAuthenticationOptions //Using coookie authentication
            {
                AuthenticationType = "ApplicationCookie",
                LoginPath = new PathString("/auth/login")
            });
        }
    }
}