using Coravel.Scheduling.Schedule.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using NuevoCase.Data;
using NuevoCase.Models;
using System.Diagnostics;

namespace NuevoCase.Controllers
{
    public class HomeController : BaseController
    {
        private readonly ILogger<HomeController> _logger;
        IScheduler _scheduler;
        public EfNuevoCase _context;
        public IActionResult Index()
        {
            ViewBag.action = action;
            return View();
        }
        public IActionResult Privacy()
        {
            //_scheduler.Schedule(
            //       () => new Jobs.Jobs().SaveMyWork()
            //   )
            //   .EveryMinute()
            //   .Weekday();
            ViewBag.action = action;
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
