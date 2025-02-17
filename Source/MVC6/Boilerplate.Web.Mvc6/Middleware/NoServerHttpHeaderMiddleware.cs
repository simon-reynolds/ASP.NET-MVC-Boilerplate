﻿namespace Boilerplate.Web.Mvc.Middleware
{
    using System.Threading.Tasks;
    using Microsoft.AspNet.Builder;
    using Microsoft.AspNet.Http;

    internal class NoServerHttpHeaderMiddleware
    {
        private const string ServerHttpHeaderName = "Server";

        private readonly RequestDelegate next;

        public NoServerHttpHeaderMiddleware(RequestDelegate next)
        {
            this.next = next;
        }

        public Task Invoke(HttpContext context)
        {
            context.Response.Headers.Remove(ServerHttpHeaderName);
            return this.next.Invoke(context);
        }
    }
}
