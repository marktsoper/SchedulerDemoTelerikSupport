using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Kendo.Mvc.Extensions;
using Kendo.Mvc.UI;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using SchedulerDemo.Models;

namespace SchedulerDemo.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }


        public virtual  JsonResult TimeLineViewRead([DataSourceRequest] DataSourceRequest request)
        {

            var list = new List<TimeLineEntryViewModel>
            {
                new TimeLineEntryViewModel
                {
                    EntryId = Guid.NewGuid(),
                    LocationAreaId = new Guid("00000000-0000-0000-0000-000000000000"),
                    Start = new DateTime(2020,6,15,0,0,0),
                    End = new DateTime(2020,6,15,2,0,0),
                    Title = "2 Hours",
                    StartTimezone = "Etc/UTC",
                    EndTimezone= "Etc/UTC"
                },
                new TimeLineEntryViewModel
                {
                    EntryId = Guid.NewGuid(),
                    LocationAreaId = new Guid("00000000-0000-0000-0000-000000000000"),
                    Start = new DateTime(2020,6,15,8,0,0),
                    End = new DateTime(2020,6,15,12,0,0),
                    Title = "4 Hours",
                    StartTimezone = "Etc/UTC",
                    EndTimezone= "Etc/UTC"
                }
            };
            return Json(list.ToDataSourceResult(request));
        }


        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
