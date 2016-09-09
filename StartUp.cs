using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http;

namespace FirstApp
{
    public class StartUp {
        public void Configure(IApplicationBuilder app)
        {
            app.Run(async (context) =>
            {
                await context.Response.WriteAsync("Nigerian Jollof is the best!");
            });
        }
    }
}