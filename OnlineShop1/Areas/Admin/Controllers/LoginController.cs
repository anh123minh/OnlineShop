using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Models1.Dao;
using OnlineShop1.Areas.Admin.Models;

namespace OnlineShop1.Areas.Admin.Controllers
{
    public class LoginController : Controller
    {
        // GET: Admin/Login
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Login(LoginModel model)
        {
            if (ModelState.IsValid)
            {
                var dao = new UserDao();
                var result = dao.Login(model.UserName, model.Password);
                if (result)
                {

                }
                else
                {
                    ModelState.AddModelError("", "dang nhap khong dung");
                }
            }
            return View("Index");
        }
    }
}