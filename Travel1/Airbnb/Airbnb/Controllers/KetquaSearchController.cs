using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Airbnb.Controllers
{
    public class KetquaSearchController : Controller
    {
        // GET: KetquaSearch
        public ActionResult Index()
        {
            return View();
        }

        // GET: KetquaSearch/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: KetquaSearch/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: KetquaSearch/Create
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

        // GET: KetquaSearch/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: KetquaSearch/Edit/5
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

        // GET: KetquaSearch/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: KetquaSearch/Delete/5
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
