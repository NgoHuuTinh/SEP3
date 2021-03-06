﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using SEPApplication3.Connect;
using SEPApplication3.Models;

namespace SEPApplication3.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            if (Session["Email"] != null)
            {
                var result = new Connect_API().GetCourse(Session["ID"] as string);
                var db = new sepoopcsEntities();
                for (int i = 0; i < result.Data.Length; i++)
                {
                    var code = result.Data[i].Id;
                    if (db.Courses.SingleOrDefault(c => c.Code == code) == null)
                    {
                        var course = new Course();
                        course.Code = result.Data[i].Id;
                        course.Name = result.Data[i].Name;
                        course.Info = result.Data[i].Info;
                        course.Lecturer = (string)Session["ID"];
                        db.Courses.Add(course);
                        db.SaveChanges();
                    }
                }
                return RedirectToAction("Index", "Courses");
            }

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
    }
}