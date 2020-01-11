using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Airbnb.Controllers
{
    public class ChiteitPhongController : Controller
    {
        // GET: ChiteitPhong
        public ActionResult Index()
        {
            return View();
        }

        // GET: ChiteitPhong/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: ChiteitPhong/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: ChiteitPhong/Create
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

        // GET: ChiteitPhong/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: ChiteitPhong/Edit/5
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

        // GET: ChiteitPhong/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: ChiteitPhong/Delete/5
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
