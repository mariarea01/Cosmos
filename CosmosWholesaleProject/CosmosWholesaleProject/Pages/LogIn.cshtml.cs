using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;

namespace CosmosWholesaleProject.Pages
{
    public class LogInModel : PageModel
    {
        private readonly ILogger<LogInModel> _logger;

        public LogInModel(ILogger<LogInModel> logger)
        {
            _logger = logger;
        }
        public void OnGet()
        {
        }
    }
}

