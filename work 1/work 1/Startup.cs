﻿using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(work_1.Startup))]
namespace work_1
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
