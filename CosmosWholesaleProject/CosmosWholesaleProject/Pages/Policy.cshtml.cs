using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;

namespace CosmosWholesaleProject.Pages
{
    public class PolicyModel : PageModel
    {
            private readonly ILogger<PolicyModel> _logger;

            public PolicyModel(ILogger<PolicyModel> logger)
            {
                _logger = logger;
            }
            public void OnGet()
        {
        }
    }
}
