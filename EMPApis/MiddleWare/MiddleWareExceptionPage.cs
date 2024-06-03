using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http;
using System.Threading.Tasks;

namespace EMPApis.MiddleWare
{
    // You may need to install the Microsoft.AspNetCore.Http.Abstractions package into your project
    public class MiddleWareExceptionPage
    {
        private readonly RequestDelegate _next;

        public MiddleWareExceptionPage(RequestDelegate next)
        {
            _next = next;
        }

        public Task Invoke(HttpContext httpContext)
        {

            return _next(httpContext);
        }
    }

    // Extension method used to add the middleware to the HTTP request pipeline.
    public static class MiddleWareExceptionPageExtensions
    {
        public static IApplicationBuilder UseMiddleWareExceptionPage(this IApplicationBuilder builder)
        {
            return builder.UseMiddleware<MiddleWareExceptionPage>();
        }
    }
}
