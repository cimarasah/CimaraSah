using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using OnMuseum.Models.Basic;
using OnMuseum.Models.Repositorio;

namespace OnMuseum.Controllers
{
    public class ObraController : Controller
    {
        private static byte[] byteArray;
        ObraRepositorio repositorio = new ObraRepositorio();
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
        public ActionResult Create(ObraBasic obraBasic)
        {
            try
            {
                obraBasic = repositorio.GerarIdObra(obraBasic);
                Image qrCodeImage = repositorio.GerarQR(obraBasic.Id, 5);
                ImageConverter converter = new ImageConverter();
                byteArray = (byte[])converter.ConvertTo(qrCodeImage, typeof(byte[]));
                Session["Obra"] = obraBasic;
                return View("GerarQrCode", obraBasic);
            }
            catch
            {
                return View();
            }
        }
        public ActionResult GerarQrCode(ObraBasic obra)
        {

            return File(byteArray, "image/jpeg");
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
