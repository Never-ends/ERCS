﻿using System.Collections.Generic;
using System.IO;
using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Localization;
using Swashbuckle.AspNetCore.Swagger;
using WalkingTec.Mvvm.Core;
using WalkingTec.Mvvm.Mvc;
using WalkingTec.Mvvm.TagHelpers.LayUI;
using Microsoft.Extensions.Logging;

namespace ERCS
{
    public class Program
    {

        public static void Main(string[] args)
        {
            BuildWebHost(args).Run();
        }

        public static IWebHost BuildWebHost(string[] args) =>
            WebHost.CreateDefaultBuilder(args)
                .ConfigureLogging((hostingContext, logging) =>
                {
                    logging.ClearProviders();
                    logging.AddConsole();
                    logging.AddDebug();
                    logging.AddWTMLogger();
                })
                .ConfigureServices(x =>
                {
                    x.AddFrameworkService();
                    x.AddLayui();
                    x.AddSwaggerGen(c =>
                    {
                        c.SwaggerDoc("v1", new Info { Title = "My API", Version = "v1" });
                        c.AddSecurityDefinition("Bearer", new ApiKeyScheme()
                        {
                            Description = "JWT Bearer",
                            Name = "Authorization",
                            In = "header",
                            Type = "apiKey"
                        });
                        c.AddSecurityRequirement(new Dictionary<string, IEnumerable<string>>
                        {
                            { "Bearer", new string[] { } }
                        });
                    });
                })
                .Configure(x =>
                {
                    var configs = x.ApplicationServices.GetRequiredService<Configs>();
                    if (configs.IsQuickDebug == true)
                    {
                        x.UseSwagger();
                        x.UseSwaggerUI(c =>
                        {
                            c.SwaggerEndpoint("/swagger/v1/swagger.json", "My API V1");
                        });
                    }
                    x.UseFrameworkService();
                })
                .Build();

    }
}
