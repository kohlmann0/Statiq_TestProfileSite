
using System;
using System.IO;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Site
{
    public class SiteConfig
    {
        public string BaseHttpAddress { get; set; }     


        public SiteConfig(string filename)
        {
            // Build configuration
            IConfigurationRoot ConfigurationRoot;      
            ConfigurationRoot = new ConfigurationBuilder()
            .SetBasePath(Directory.GetParent(AppContext.BaseDirectory).FullName)
            .AddJsonFile("appsettings.json", false)
            .Build();

            this.BaseHttpAddress = ConfigurationRoot?.GetSection("ConnectionStrings")?.GetValue<string>("baseHttpAddress") ?? String.Empty;
        }


    }
}