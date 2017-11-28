using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ServiceStack.ServiceHost;
using ServiceStack.WebHost.Endpoints;

namespace WorkTeamServices
{
    public class Global : System.Web.HttpApplication
    {
        public class AppHost : AppHostBase
        {
            public AppHost()
                : base("WorkTeamServices REST", typeof(CustomerService).Assembly)
            {

            }

            public override void Configure(Funq.Container container)
            {
                //Register user-defined REST-ful urls. You can access the service at the url similar to the following.
                //http://localhost/ServiceStack.Hello/servicestack/hello or http://localhost/ServiceStack.Hello/servicestack/hello/John%20Doe
                //You can change /servicestack/ to a custom path in the web.config.
                Routes
                  .Add<Hello>("/hello")
                  .Add<Hello>("/hello/{Name}");
            }
        }

        //Initialize your application singleton
        protected void Application_Start(object sender, EventArgs e)
        {
            new AppHost().Init();
        }
    }
    
}