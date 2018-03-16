using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using CRM_wJames.Models;

namespace CRM_wJames.Controllers
{
    public class ProjectStagesController : Controller
    {
        private CMR_dbEntities db = new CMR_dbEntities();

        // GET: ProjectStages
        public ActionResult Index()
        {
            return View(db.ProjectStages.ToList());
        }

        // GET: ProjectStages/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ProjectStage projectStage = db.ProjectStages.Find(id);
            if (projectStage == null)
            {
                return HttpNotFound();
            }
            return View(projectStage);
        }

        // GET: ProjectStages/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: ProjectStages/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ProjectStageID,ProjectStageName")] ProjectStage projectStage)
        {
            if (ModelState.IsValid)
            {
                db.ProjectStages.Add(projectStage);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(projectStage);
        }

        // GET: ProjectStages/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ProjectStage projectStage = db.ProjectStages.Find(id);
            if (projectStage == null)
            {
                return HttpNotFound();
            }
            return View(projectStage);
        }

        // POST: ProjectStages/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ProjectStageID,ProjectStageName")] ProjectStage projectStage)
        {
            if (ModelState.IsValid)
            {
                db.Entry(projectStage).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(projectStage);
        }

        // GET: ProjectStages/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ProjectStage projectStage = db.ProjectStages.Find(id);
            if (projectStage == null)
            {
                return HttpNotFound();
            }
            return View(projectStage);
        }

        // POST: ProjectStages/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            ProjectStage projectStage = db.ProjectStages.Find(id);
            db.ProjectStages.Remove(projectStage);
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
