using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MvcApplication1.Models;

namespace MvcApplication1.Controllers
{
    public class OS_RecordModelController : Controller
    {
        private MvcApplication1Context db = new MvcApplication1Context();

        //
        // GET: /OS_RecordModel/

        public ActionResult Index()
        {
            return View(db.OS_RecordModel.ToList());
        }

        //
        // GET: /OS_RecordModel/Details/5

        public ActionResult Details(string id = null)
        {
            OS_RecordModel os_recordmodel = db.OS_RecordModel.Find(id);
            if (os_recordmodel == null)
            {
                return HttpNotFound();
            }
            return View(os_recordmodel);
        }

        //
        // GET: /OS_RecordModel/Create

        public ActionResult Create()
        {
            return View();
        }

        //
        // POST: /OS_RecordModel/Create

        [HttpPost]
        public ActionResult Create(OS_RecordModel os_recordmodel)
        {
            if (ModelState.IsValid)
            {
                db.OS_RecordModel.Add(os_recordmodel);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(os_recordmodel);
        }

        //
        // GET: /OS_RecordModel/Edit/5

        public ActionResult Edit(string id = null)
        {
            OS_RecordModel os_recordmodel = db.OS_RecordModel.Find(id);
            if (os_recordmodel == null)
            {
                return HttpNotFound();
            }
            return View(os_recordmodel);
        }

        //
        // POST: /OS_RecordModel/Edit/5

        [HttpPost]
        public ActionResult Edit(OS_RecordModel os_recordmodel)
        {
            if (ModelState.IsValid)
            {
                db.Entry(os_recordmodel).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(os_recordmodel);
        }

        //
        // GET: /OS_RecordModel/Delete/5

        public ActionResult Delete(string id = null)
        {
            OS_RecordModel os_recordmodel = db.OS_RecordModel.Find(id);
            if (os_recordmodel == null)
            {
                return HttpNotFound();
            }
            return View(os_recordmodel);
        }

        //
        // POST: /OS_RecordModel/Delete/5

        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirmed(string id)
        {
            OS_RecordModel os_recordmodel = db.OS_RecordModel.Find(id);
            db.OS_RecordModel.Remove(os_recordmodel);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            db.Dispose();
            base.Dispose(disposing);
        }
    }
}