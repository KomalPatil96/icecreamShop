using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace icecreamShop.Controllers
{
    public class IceShopController : Controller
    {
        // GET: IceShop
        public ActionResult Index()
        {
            return View();
        }
    }
}