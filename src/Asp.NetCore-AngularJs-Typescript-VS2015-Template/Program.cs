﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;

namespace Asp.NetCore_AngularJs_Typescript_VS2015_Template
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int port = 5000;

            var host = new WebHostBuilder()
                .UseKestrel()
                .UseContentRoot(Directory.GetCurrentDirectory())
                .UseIISIntegration()
                .UseStartup<Startup>()
                .UseUrls("http://localhost:" + port)
                .Build();

            host.Run();
        }
    }
}
