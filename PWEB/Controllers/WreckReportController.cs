using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PWEB.Controllers
{
    public class WreckReportController : Controller
    {
        // GET: WreckReport
        public ActionResult Index()
        {
            return View();
        }

        // GET: WreckReport/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: WreckReport/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: WreckReport/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction("CreateWReport");
            }
            catch
            {
                return View();
            }
        }

        // GET: WreckReport/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: WreckReport/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("WreckReports");
            }
            catch
            {
                return View();
            }
        }

        // GET: WreckReport/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: WreckReport/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("WreckReports");
            }
            catch
            {
                return View();
            }
        }
    }
}
