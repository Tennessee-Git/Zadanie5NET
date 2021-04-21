using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using Zadanie5NET.Middleware;
using Shyjus.BrowserDetection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Zadanie5NET.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;
        public string browserName;


        public IndexModel(ILogger<IndexModel> logger)
        {
            _logger = logger;
            //browserName = HttpContext.Session.GetString("BrowserName");
        }

        public void OnGet()
        {

        }
    }
}
