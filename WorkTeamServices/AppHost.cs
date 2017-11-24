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
        }
    }
    
}