using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.Owin;
using Owin;

[assembly: OwinStartup(typeof(WebApiBook.ProcessingArchitecture.ProcessesApi.v2.Startup))]

namespace WebApiBook.ProcessingArchitecture.ProcessesApi.v2
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
