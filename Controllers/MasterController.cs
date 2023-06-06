using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace RealEstate.Controllers
{
    public class MasterController : Controller
    {
        // GET: Master
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult AddSite()
        {
            return View();
        }

        public ActionResult AddPlot()
        {
            return View();
        }

        public ActionResult AddPlotType()
        {
            return View();
        }

        public ActionResult AddBlock()
        {
            return View();
        }


    }
}