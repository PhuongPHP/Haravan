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
        [Authorize]
        public ActionResult TatCaDonHang()
        {
            return View();
        }
        [Authorize]
        public ActionResult TaoDonHang()
        {
            return View();
        }
    }
}