﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace RealEstate.Controllers
{
    public class CRMController : Controller
    {
        // GET: CRM
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult AddLead()
        {
            return View();
        }

        public ActionResult FollowUp()
        {
            return View();
        }

        public ActionResult LeadList()
        {
            return View();
        }
    }
}