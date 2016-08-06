using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace GuestBook.Filter
{
    public class LoginFilter : ActionFilterAttribute
    {
        public override void OnActionExecuted(ActionExecutedContext filterContext)
        {
            base.OnActionExecuted(filterContext);

        }

        public override void OnActionExecuting(ActionExecutingContext filterContext)
        {
            base.OnActionExecuting(filterContext);
            if (HttpContext.Current.Session["admin"] == null)
            {
                //如果Session为空，跳转到登录页面
                HttpContext.Current.Response.Redirect("/Home/Login");
            }
        }
    }
}