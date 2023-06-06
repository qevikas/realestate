﻿using RealEstate.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using RealEstate.DB_Logic;

namespace RealEstate.Controllers
{
    public class HomeController : Controller
    {
        BusinessLayer bl = new BusinessLayer();

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public ActionResult Properties()
        {
            return View();
        }

        public ActionResult PropertyDetails()
        {
            return View();
        }

        public ActionResult Projects()
        {
            return View();
        }

        public ActionResult PlotAvailability()
        {
            return View();
        }

        public ActionResult Gallery()
        {
            return View();
        }

        [HttpGet]
        public ActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Login( Login obj)
        {
            try
            {
                string url = "/home/login";
                obj.Action = 1;
                obj.dt = bl.GetLogins(obj);
                if (obj.dt != null && obj.dt.Rows.Count > 0)
                {
                    Session["UserName"] = obj.UserName;
                    Session["Password"] = obj.Password;
                    Session["Role"] = obj.dt.Rows[0]["Psw"].ToString();
                    Session["URL"] = obj.dt.Rows[0]["URL"].ToString();
                    url = Session["URL"].ToString();
                    Response.Redirect(url);
                }
                else
                    Response.Write("<script>alert('Please enter a valid Username and Password!');</script>");
            }
            catch (Exception exc)
            {
                Response.Write("<script>alert('" + exc.Message + "');</script>");
            }
            
            return View();
        }

        public ActionResult Services()
        {
            return View();
        }

        public ActionResult LogOut()
        {
            Session.Abandon();
            Session.RemoveAll();
            Session.Clear();
            return View();
        }

    }
} 