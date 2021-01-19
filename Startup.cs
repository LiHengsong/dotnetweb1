using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Logging;
using Microsoft.AspNetCore.Http;

namespace hellobook{
    public class Startup{
        public Startup(IHostingEnvironment environment){

        }

        public void Configure(IApplicationBuilder application,
            IHostingEnvironment environment, ILoggerFactory loggerFactory){
                application.Run(
                    async(context)=>{
                        await context.Response.WriteAsync("Hello World");
                    }
                );
        }
    }
}