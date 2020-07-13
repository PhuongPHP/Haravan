using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebHaravan.Controllers
{
    public class GomiController : Controller
    {
        // GET: Gomi
        public ActionResult TatCaDonHang()
        {
            return View();
        }
        public ActionResult TaoDonHang()
        {
            return View();
        }
    }
}