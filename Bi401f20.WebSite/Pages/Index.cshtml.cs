using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Bi401f20.WebSite.Modles;
using ContosoCrafts.WebSite.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;

namespace Bi401f20.WebSite.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;
        public JsonFileAnmeldelseService AnmeldelseService;
        public IEnumerable<Anmeldelse> Anmeldelser { get; private set; }

        public IndexModel(ILogger<IndexModel> logger,
            JsonFileAnmeldelseService anmeldelse)
        {
            _logger = logger;
            AnmeldelseService = anmeldelse;
        }

        public void OnGet()
        {
            Anmeldelser = AnmeldelseService.GetAnmeldelser();
        }
    }
}
