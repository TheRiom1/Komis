using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Komis.Models;

namespace Komis.Controllers
{
    public class sprzedazsController : Controller
    {
        private komisEntities db = new komisEntities();
        private komisEntities1 ds = new komisEntities1();

        // GET: sprzedazs
        public ActionResult Index()
        {
            return View(db.sprzedazs.ToList());
        }

        [HttpGet]
        public ActionResult GetCar()
        {
            var car = ds.VINs.ToList();

            return Json(car, JsonRequestBehavior.AllowGet);

        }
        // GET: sprzedazs/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            sprzedaz sprzedaz = db.sprzedazs.Find(id);
            if (sprzedaz == null)
            {
                return HttpNotFound();
            }
            return View(sprzedaz);
        }

        // GET: sprzedazs/Create
        public ActionResult Create()
        {
            return View(new sprzedaz());
        }

        // POST: sprzedazs/Create
        // Aby zapewnić ochronę przed atakami polegającymi na przesyłaniu dodatkowych danych, włącz określone właściwości, z którymi chcesz utworzyć powiązania.
        // Aby uzyskać więcej szczegółów, zobacz https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "id,carid,custid,cena,data_sprzedazy")] sprzedaz sprzedaz)
        {
            if (ModelState.IsValid)
            {
                db.sprzedazs.Add(sprzedaz);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(sprzedaz);
        }


        [HttpPost]
        public ActionResult Getid(int id)
        {
            var customer = (from s in db.customer where s.id == id select s.id).ToList();
            return Json(customer, JsonRequestBehavior.AllowGet);

        }

        // GET: sprzedazs/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            sprzedaz sprzedaz = db.sprzedazs.Find(id);
            if (sprzedaz == null)
            {
                return HttpNotFound();
            }
            return View(sprzedaz);
        }

        // POST: sprzedazs/Edit/5
        // Aby zapewnić ochronę przed atakami polegającymi na przesyłaniu dodatkowych danych, włącz określone właściwości, z którymi chcesz utworzyć powiązania.
        // Aby uzyskać więcej szczegółów, zobacz https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "id,carid,custid,cena,data_sprzedazy")] sprzedaz sprzedaz)
        {
            if (ModelState.IsValid)
            {
                db.Entry(sprzedaz).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(sprzedaz);
        }

        // GET: sprzedazs/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            sprzedaz sprzedaz = db.sprzedazs.Find(id);
            if (sprzedaz == null)
            {
                return HttpNotFound();
            }
            return View(sprzedaz);
        }

        // POST: sprzedazs/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            sprzedaz sprzedaz = db.sprzedazs.Find(id);
            db.sprzedazs.Remove(sprzedaz);
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
