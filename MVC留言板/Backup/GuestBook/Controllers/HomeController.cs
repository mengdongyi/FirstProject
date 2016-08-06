using System;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using DAL;
using EF;
using System.Collections.Generic;

namespace GuestBook.Controllers
{
    public class HomeController : Controller
    {
        //
        // GET: /Home/

        [Filter.LoginFilter]
        public ActionResult Index()
        {
            //ViewData["Messages"] = MessageDAL.GetMessages();
            return View("Add");
        }

        [Filter.LoginFilter]
        public JsonResult Add()
        {
            JsonResult jr = new JsonResult();
            if (string.IsNullOrEmpty(Request.Params["nickName"]) || string.IsNullOrEmpty(Request.Params["messageContent"]))
            {
                jr.Data = MessageDAL.GetMessages();
                //jr.JsonRequestBehavior = JsonRequestBehavior.AllowGet;
                return jr;
            }
            Message message = new Message();
            message.MessageTitle = Request.Params["nickName"];
            message.MessageContent = Request.Params["messageContent"];
            message.PostTime = DateTime.Now;
            MessageDAL.Add(message);
            jr.Data = MessageDAL.GetMessages();
            //jr.JsonRequestBehavior = JsonRequestBehavior.AllowGet;
            return jr;
        }

        public JsonResult Delete()
        {
            int id = Convert.ToInt32(Request.Params["id"]);
            MessageDAL.Delete(id);
            JsonResult jr = new JsonResult();
            jr.Data = MessageDAL.GetMessages();
            return jr;
        }

        public JsonResult Update()
        {
            Message message = new Message();
            message.id = Convert.ToInt32(Request.Params["id"]);
            message.MessageTitle = Request.Params["nickName"];
            message.MessageContent = Request.Params["messageContent"];
            message.PostTime = DateTime.Now;
            MessageDAL.Update(message);
            JsonResult jr = new JsonResult();
            jr.Data = MessageDAL.GetMessages();
            return jr;
        }

        public ActionResult List()
        {
            List<Message> list = MessageDAL.GetMessages();
            return View(list);
        }

        public ActionResult Login(FormCollection col)
        {
            string userName = col["userName"];
            string pwd = col["pwd"];
            if (userName == "admin" && pwd == "123")
            {
                Session["admin"] = "admin";
                return View("Add");
            }
            return View();
        }

        public ActionResult FenBu()
        {
            return View();
        }

    }
}
