using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;

namespace CosmosWholesaleProject.Pages
{
    public class ElectronicsModel : PageModel
    {
        private readonly ILogger<ElectronicsModel> _logger;

        public ElectronicsModel(ILogger<ElectronicsModel> logger)
        {
            _logger = logger;
        }
        public void OnGet()
        {
        }
    }
}
