//using System;
//using System.Collections.Generic;
//using System.Data;
//using System.Data.Entity;
//using System.Linq;
//using System.Net;
//using System.Web;
//using System.Web.Mvc;
//using OpenOrderFramework.Models;

//namespace OpenOrderFramework.Controllers
//{
//    public class AccessoriesController : Controller
//    {
//        private ApplicationDbContext db = new ApplicationDbContext();

//        // GET: Accessories
//        public ActionResult Index()
//        {
//            return View(db.Accessories.ToList());
//        }

//        // GET: Accessories/Details/5
//        public ActionResult Details(int? id)
//        {
//            if (id == null)
//            {
//                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
//            }
//            Accessorie accessorie = db.Accessories.Find(id);
//            if (accessorie == null)
//            {
//                return HttpNotFound();
//            }
//            return View(accessorie);
//        }

//        // GET: Accessories/Create
//        public ActionResult Create(int id)
//        {
//            Item item = db.Items.Find(id);
//            //item = new Item() { ID = id };
//            return View(item);
//        }

//        // POST: Accessories/Create
//        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
//        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
//        [HttpPost]
//        [ValidateAntiForgeryToken]
//        public void Create([Bind(Include = "accID,ketchup,mayonnaise,fries,ID")] Accessorie accessorie)
//        {
//            if (ModelState.IsValid)
//            {
//                db.Accessories.Add(accessorie);
//                db.SaveChanges();
//                //return RedirectToAction("Index");
//            }

//            //return View(accessorie);
//        }

//        // GET: Accessories/Edit/5
//        public ActionResult Edit(int? id)
//        {
//            if (id == null)
//            {
//                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
//            }
//            Accessorie accessorie = db.Accessories.Find(id);
//            if (accessorie == null)
//            {
//                return HttpNotFound();
//            }
//            return View(accessorie);
//        }

//        // POST: Accessories/Edit/5
//        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
//        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
//        [HttpPost]
//        [ValidateAntiForgeryToken]
//        public ActionResult Edit([Bind(Include = "accID,ketchup,mayonnaise,fries")] Accessorie accessorie)
//        {
//            if (ModelState.IsValid)
//            {
//                db.Entry(accessorie).State = EntityState.Modified;
//                db.SaveChanges();
//                return RedirectToAction("Index");
//            }
//            return View(accessorie);
//        }

//        // GET: Accessories/Delete/5
//        public ActionResult Delete(int? id)
//        {
//            if (id == null)
//            {
//                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
//            }
//            Accessorie accessorie = db.Accessories.Find(id);
//            if (accessorie == null)
//            {
//                return HttpNotFound();
//            }
//            return View(accessorie);
//        }

//        // POST: Accessories/Delete/5
//        [HttpPost, ActionName("Delete")]
//        [ValidateAntiForgeryToken]
//        public ActionResult DeleteConfirmed(int id)
//        {
//            Accessorie accessorie = db.Accessories.Find(id);
//            db.Accessories.Remove(accessorie);
//            db.SaveChanges();
//            return RedirectToAction("Index");
//        }

//        protected override void Dispose(bool disposing)
//        {
//            if (disposing)
//            {
//                db.Dispose();
//            }
//            base.Dispose(disposing);
//        }
//    }
//}
