using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace OnMuseum.Controllers
{
    public class ObraController : Controller
    {
        // GET: Obra
        public ActionResult Index()
        {
            return View();
        }

        // GET: Obra/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Obra/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Obra/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Obra/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Obra/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Obra/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Obra/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
