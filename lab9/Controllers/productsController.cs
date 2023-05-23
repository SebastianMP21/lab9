using lab9.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace lab9.Controllers
{
    public class productsController : Controller
    {
        private NeptunoEntities db = new NeptunoEntities();
        // GET: productos
        public ActionResult Index()
        {
            return View(db.productos.ToList());
        }
    }
}