using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;
using WebHaravan.Models.Account;

namespace WebHaravan.Controllers
{
    public class LoginController : Controller
    {
        // Action Login
        public ViewResult Login(string returnURL)
        {
            ViewBag.returnURL = returnURL;
            return View();
        }
        [HttpPost]
        [AllowAnonymous]
        [ValidateAntiForgeryToken]
        public ActionResult Login(AccountModel acc, string returnUrl)
        {
            if (ModelState.IsValid)
            {
                if(acc.Username == "admindev" && acc.Password == "@123456$")
                {
                    FormsAuthentication.SetAuthCookie(acc.Username, true);
                    return RedirectToLocal(returnUrl);
                }
            }
            return View(acc);
        }
        // Dang xuat
        public ActionResult Logoff()
        {
            FormsAuthentication.SignOut();
            return RedirectToAction("Login", "Login");
        }
        // Kiểm tra returnURL có thuộc hệ thống hay không
        private ActionResult RedirectToLocal(string returnURL)
        {
            if (Url.IsLocalUrl(returnURL))
            {
                return Redirect(returnURL);
            }
            else
            {
                return RedirectToAction("Index", "Home");
            }
        }
    }
}