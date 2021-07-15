using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcProjeKampi.Controllers
{
    public class MessageController : Controller
    {

        MessageManager cm = new MessageManager(new EfMessageDal());


        public ActionResult Inbox()
        {
            var messageList = cm.GetListInbox();
            return View(messageList);
        }

        public ActionResult SendBox()
        {
            var messageList = cm.GetListSendBox();
            return View(messageList);
        }
        [HttpGet]
        public ActionResult NewMessage()
        {
            return View();
        }
        [HttpPost]
        public ActionResult NewMessage(MessageController p)
        {
            return View();
        }
    }
}