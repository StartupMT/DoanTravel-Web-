using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Airbnb.Controllers
{
    public class ThongBaoController : Controller
    {
        // GET: ThongBao
        public ActionResult Index()
        {
            return View();
        }

        // GET: ThongBao/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: ThongBao/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: ThongBao/Create
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

        // GET: ThongBao/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: ThongBao/Edit/5
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

        // GET: ThongBao/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: ThongBao/Delete/5
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
