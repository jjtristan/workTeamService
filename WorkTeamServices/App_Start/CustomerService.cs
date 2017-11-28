using ServiceStack.ServiceInterface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WorkTeamServices
{
    public class CustomerService : Service
    {
        //public object Get(GetCustomerSevice)
        public object Any(Hello request)
        {
            //Looks strange when the name is null so we replace with a generic name.
            var name = request.Name ?? "John Doe";
            return new HelloResponse { Result = "Hello, " + name };
        }
    }

    public class Hello
    {
        public string Name { get; set; }
    }

    public class HelloResponse
    {
        public string Result { get; set; }
    }
}