using System;
using System.Net;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace web_practice
{
    public class Startup
    {
        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940

        private Random rand = new Random();
        private Phrases phrases = new Phrases();

        private String[] url = {
            "http://localhost:5001",
            "http://localhost:5002",
            "http://localhost:5003",
            "http://localhost:5004",
        }; 

        public void ConfigureServices(IServiceCollection services)
        {
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseRouting();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapGet("/", async context =>
                {
                    context.Response.ContentType = "text/html; charset=utf-8";
                    context.Response.Headers["InCamp-Student"] = "Andrew Maslyuk";
                    await context.Response.WriteAsync("Hello World!");
                });

                endpoints.MapGet("/who", async context =>
                {
                    context.Response.ContentType = "text/html; charset=utf-8";
                    context.Response.Headers["InCamp-Student"] = "Andrew Maslyuk";
                    await context.Response.WriteAsync(phrases.GetRandomWho());
                });

                endpoints.MapGet("/how", async context =>
                {
                    context.Response.ContentType = "text/html; charset=utf-8";
                    context.Response.Headers["InCamp-Student"] = "Andrew Maslyuk";
                    await context.Response.WriteAsync(phrases.GetRandomHow());
                });

                endpoints.MapGet("/does", async context =>
                {
                    context.Response.ContentType = "text/html; charset=utf-8";
                    context.Response.Headers["InCamp-Student"] = "Andrew Maslyuk";
                    await context.Response.WriteAsync(phrases.GetRandomDoes());
                });

                endpoints.MapGet("/what", async context =>
                {
                    context.Response.ContentType = "text/html; charset=utf-8";
                    context.Response.Headers["InCamp-Student"] = "Andrew Maslyuk";
                    await context.Response.WriteAsync(phrases.GetRandomWhat());
                });

                endpoints.MapGet("/quote", async context =>
                {
                    context.Response.ContentType = "text/html; charset=utf-8";
                    context.Response.Headers["InCamp-Student"] = "Andrew Maslyuk";
                    await context.Response.WriteAsync(phrases.GetRandomWho() + " " +
                    phrases.GetRandomHow() + " " +
                    phrases.GetRandomDoes() + " " +
                    phrases.GetRandomWhat());
                });

                endpoints.MapGet("/incamp18-quote", async context =>
                {
                    context.Response.ContentType = "text/html; charset=utf-8";
                    context.Response.Headers["InCamp-Student"] = "Andrew Maslyuk";
                    await context.Response.WriteAsync( 
                        GetIncampWord(GetRandomUrl(), "who") + "<br>" +
                        GetIncampWord(GetRandomUrl(), "how") + "<br>" +
                        GetIncampWord(GetRandomUrl(), "does") + "<br>" +
                        GetIncampWord(GetRandomUrl(), "what") + "<br>");
                });

            });
        }

        private String GetRandomUrl(){
            return url[rand.Next(url.Length)]; 
        }

        private static String GetIncampWord(string url, string wordType)
        {

            WebResponse response = WebRequest.Create($"{url}/{wordType}").GetResponse();

            String internName = response.Headers.GetValues("InCamp-Student").First();
            String incampWord = "";

            using (var read = new System.IO.StreamReader(response.GetResponseStream(), UTF8Encoding.UTF8))
            {
                incampWord += read.ReadToEnd();
            }

            return "Student: " + internName + "\t Word type: " + wordType + "\t Word: " + incampWord;
        }
    }
}
