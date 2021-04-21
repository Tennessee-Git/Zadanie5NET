using Microsoft.AspNetCore.Http;
using Shyjus.BrowserDetection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Zadanie5NET.Middleware
{
    public class BrowserNameMiddleware
    {
        private RequestDelegate _next;

        public BrowserNameMiddleware(RequestDelegate next)
        {
            _next = next;
        }
        public async Task InvokeAsync(HttpContext context, IBrowserDetector detector)
        {
            var browser = detector.Browser;
            if(browser.Name == BrowserNames.Edge || browser.Name == BrowserNames.EdgeChromium
                || browser.Name == BrowserNames.InternetExplorer)
            {
                await context.Response.WriteAsync("Przeglądarka nie jest obsługiwana");
            }
            else
                await _next.Invoke(context);
        }
    }
}
