using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using SandlingMIS4200.DAL;
using SandlingMIS4200.Models;

namespace SandlingMIS4200.Controllers
{
    public class instructorsController : Controller
    {
        private MIS4200Context db = new MIS4200Context();

        // GET: instructors
        public ActionResult Index()
        {
            return View(db.instructors.ToList());
        }

        // GET: instructors/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            instructor instructor = db.instructors.Find(id);
            if (instructor == null)
            {
                return HttpNotFound();
            }
            return View(instructor);
        }

        // GET: instructors/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: instructors/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "instructorID,firstName,lastName,email,phone,officeNumber,instructorSince")] instructor instructor)
        {
            if (ModelState.IsValid)
            {
                db.instructors.Add(instructor);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(instructor);
        }

        // GET: instructors/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            instructor instructor = db.instructors.Find(id);
            if (instructor == null)
            {
                return HttpNotFound();
            }
            return View(instructor);
        }

        // POST: instructors/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "instructorID,firstName,lastName,email,phone,officeNumber,instructorSince")] instructor instructor)
        {
            if (ModelState.IsValid)
            {
                db.Entry(instructor).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(instructor);
        }

        // GET: instructors/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            instructor instructor = db.instructors.Find(id);
            if (instructor == null)
            {
                return HttpNotFound();
            }
            return View(instructor);
        }

        // POST: instructors/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            instructor instructor = db.instructors.Find(id);
            db.instructors.Remove(instructor);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
