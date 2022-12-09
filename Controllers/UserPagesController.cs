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

        //private IContentService _contentService;

        private readonly ILogger<HomeController> _logger;

        public UserPagesController(ILogger<HomeController> logger)
        {
            _logger = logger;
            //_contentService = contentService;
        }

        public IActionResult Index()
        {
            return View(new UserPagesViewModel() {
                Pages = new List<Page>()
            {
                new Page()
                {
                    Title = "Page 1",
                    PageContent = new System.Collections.Generic.List<TextContent>()
                    {
                        new TextContent()
                        {
                            Text = "Page1 Header"
                        },
                        new TextContent()
                        {
                            Text = "Page Content"
                        },
                    }
                },
                new Page()
                {
                    Title = "Page 2",
                    PageContent = new System.Collections.Generic.List<TextContent>()
                    {
                        new TextContent()
                        {
                            Text = "Page2 Header"
                        },
                        new TextContent()
                        {
                            Text = "Page Content"
                        },
                    }
                }
            }
            });
        }
    }
}

