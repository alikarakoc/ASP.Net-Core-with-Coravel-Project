using Coravel.Scheduling.Schedule.Interfaces;
using Microsoft.AspNetCore.Mvc;
using NuevoCase.Data.Models;
using NuevoCase.Tasks;
using System.Linq;

namespace NuevoCase.Controllers
{
    public class DashboardController : BaseController
    {
        public IScheduler _scheduler;

        public DashboardController(IScheduler s)
        {
            _scheduler = s;
        }
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult AddTask()
        {
            return View();
        }
        public IActionResult Tasks()
        {
            var data = db.Urls.ToList();
            return View(data);
        }

        public IActionResult AddTaskPost(string SiteUrl, string Period)
        {
            Urls urls = new Urls()
            {
                Id = 0,
                SiteUrl = SiteUrl,
                Period = Period
            };
            db.Urls.Add(urls);
            db.SaveChanges();
            _scheduler.Schedule(() => new MyJobs().CheckUrl(urls.Id)).Cron(Period);
            return Json(true);
        }
    }
}