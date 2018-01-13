using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Shop.Web.Framework
{
    public class MyMiddleware
    {
        private readonly RequestDelegate _next; // prywatne pole

        public MyMiddleware(RequestDelegate next) // konstruktor
        {
            _next = next;
        }

        public async Task Invoke(HttpContext httpContext) // metoda wywołująca framework MyMiddleware; async - pozbywamy się wiszącego połączenia które czeka na dane z np. bazy danych (przy operacjach InOut, które dzieją się "na zewnątrz")
        {
            Console.WriteLine($"My middleware: {httpContext.Request.Path}");
            await _next.Invoke(httpContext);
        }
    }
}
