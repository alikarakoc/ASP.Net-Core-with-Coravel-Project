using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using NuevoCase.Data;

namespace NuevoCase.Controllers
{

    public abstract class BaseController : Controller
    {
        public string controller = "";
        public string action = "";
        public EfNuevoCase db;
        protected BaseController()
        {
            db = new EfNuevoCase();
        }
        public override void OnActionExecuting(ActionExecutingContext context)
        {
            controller = context.RouteData.Values["controller"].ToString();
            action = context.RouteData.Values["action"].ToString();

            if (User.Identity.Name == null)
            {
                context.Result = new RedirectResult("/login/index");
                return;
            }

            base.OnActionExecuting(context);
        }
    }
}