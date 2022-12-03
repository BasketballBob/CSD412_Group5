using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using GroupAssignment.Models;
using GroupAssignment.Service;

namespace GroupAssignment.Controllers
{
    public class UserPagesController : Controller
    {

        private IContentService _contentService;

        private readonly ILogger<HomeController> _logger;

        public UserPagesController(IContentService contentService, ILogger<HomeController> logger)
        {
            _logger = logger;
            _contentService = contentService;
        }

        public IActionResult Index()
        {
            foreach (Page p in _contentService.GetUserPages(Guid.Empty))
            {
                Console.WriteLine(p.Title);
            }
            return View(new UserPagesViewModel() {
                Pages = _contentService.GetUserPages(Guid.Empty)
            });
        }
    }
}

