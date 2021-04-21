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
        private readonly RequestDelegate _next;

        public BrowserNameMiddleware(RequestDelegate next)
        {
            _next = next;
        }
        public async Task InvokeAsync(HttpContext context, IBrowserDetector detector)
        {
            var browser = detector.Browser;
            //context.Session.SetString("BrowserName", browser.Name);

            if (browser.Name == BrowserNames.Edge || browser.Name == BrowserNames.EdgeChromium
                || browser.Name == BrowserNames.InternetExplorer)
            {
                await context.Response.WriteAsync("Przeglądarka nie jest obsługiwana");
            }
            await _next(context);
        }

    }
}
