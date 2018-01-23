using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Web.Http;
using System.Web.Mvc;

namespace UniversalBlockChain.Deamon
{
    class Program
    {
        static void Main(string[] args)
        {
            var host = new WebHostBuilder()
                           .UseKestrel()
                           .UseStartup<Startup>()
                           .Build();

            host.RunAsync();

            Console.WriteLine("dsdqsdsq");

            Console.ReadLine();
        }
    }

    public class Startup
    {
        public void ConfigureServices(IServiceCollection services)
        {
            var builder = services.AddMvc();
            //Load Plugin
//            builder.AddApplicationPart(
//    AssemblyLoadContext.Default.LoadFromAssemblyPath(
//        @"PATH\ExternalControllers.dll"
//));
        }

        public void Configure(IApplicationBuilder app)
        {
            app.UseMvc();
        }
    }

    // Example controller
    public class TestController : Controller
    {
        [Microsoft.AspNetCore.Mvc.HttpGet("api/helloworld")]
        public object HelloWorld()
        {
            return new { message = "Hello World" };
        }
    }
}
