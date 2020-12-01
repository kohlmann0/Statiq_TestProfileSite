using System;
using System.IO;
using System.Threading.Tasks;
using Statiq.App;
using Statiq.Web;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;


namespace Site
{

  public class Program
  {
    public static SiteConfig Config  { get; set; }  
        
    public static async Task Main(string[] args)
    {
      Config = new SiteConfig("appsettings.json");

      await Bootstrapper
        .Factory
        .CreateWeb(args)        
        .RunAsync();
    }


  }
}