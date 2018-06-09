using P.Domain.Entities;
using P.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PWEB.Controllers
{
    public class VehicleController : Controller
    {
        VehicleService vs = new VehicleService();
        UserService us = new UserService();
        FiscalPowerService fps = new FiscalPowerService();

        // GET: Vehicle
        public ActionResult Vehicles()
        {
            var vehicles = vs.GetAll();
            return View();
        }
        

        // GET: Vehicle/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Vehicle/Create
        public ActionResult Create()
        {
            var users = us.GetAll();          
            ViewBag.User = new SelectList(users, "IdUser", "Name");
            var fpowers = fps.GetAll();
            ViewBag.FiscalPower = new SelectList(fpowers, "IdFiscalPower", "FPower");

            return View();
        }

        // POST: Vehicle/Create
        [HttpPost]
        public ActionResult Create(Vehicle v, HttpPostedFileBase file)
        {
            
                vs.Add(v);
                vs.Commit();
                return RedirectToAction("Vehicles");
           
        }

        // GET: Vehicle/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Vehicle/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Vehicles");
            }
            catch
            {
                return View();
            }
        }

        // GET: Vehicle/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Vehicle/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Vehicles");
            }
            catch
            {
                return View();
            }
        }
    }
}
