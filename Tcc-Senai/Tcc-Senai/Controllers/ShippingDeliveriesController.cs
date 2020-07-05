using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using TCC_Senai.Models;
using TCC_Senai.Models.Context;

namespace TCC_Senai.Controllers
{
    public class ShippingDeliveriesController : Controller
    {
        private SysgamesContext db = new SysgamesContext();

        // GET: ShippingDeliveries
        public ActionResult Index()
        {
            return View(db.ShippingDeliveries.ToList());
        }

        // GET: ShippingDeliveries/Details/5
        public ActionResult Details(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ShippingDelivery shippingDelivery = db.ShippingDeliveries.Find(id);
            if (shippingDelivery == null)
            {
                return HttpNotFound();
            }
            return View(shippingDelivery);
        }

        // GET: ShippingDeliveries/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: ShippingDeliveries/Create
        // Para se proteger de mais ataques, habilite as propriedades específicas às quais você quer se associar. Para 
        // obter mais detalhes, veja https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,EstimateDate,DeliveryDate,DeliveryValue,QuantityDelivered,CreationDate")] ShippingDelivery shippingDelivery)
        {
            if (ModelState.IsValid)
            {
                db.ShippingDeliveries.Add(shippingDelivery);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(shippingDelivery);
        }

        // GET: ShippingDeliveries/Edit/5
        public ActionResult Edit(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ShippingDelivery shippingDelivery = db.ShippingDeliveries.Find(id);
            if (shippingDelivery == null)
            {
                return HttpNotFound();
            }
            return View(shippingDelivery);
        }

        // POST: ShippingDeliveries/Edit/5
        // Para se proteger de mais ataques, habilite as propriedades específicas às quais você quer se associar. Para 
        // obter mais detalhes, veja https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,EstimateDate,DeliveryDate,DeliveryValue,QuantityDelivered,CreationDate")] ShippingDelivery shippingDelivery)
        {
            if (ModelState.IsValid)
            {
                db.Entry(shippingDelivery).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(shippingDelivery);
        }

        // GET: ShippingDeliveries/Delete/5
        public ActionResult Delete(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ShippingDelivery shippingDelivery = db.ShippingDeliveries.Find(id);
            if (shippingDelivery == null)
            {
                return HttpNotFound();
            }
            return View(shippingDelivery);
        }

        // POST: ShippingDeliveries/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(string id)
        {
            ShippingDelivery shippingDelivery = db.ShippingDeliveries.Find(id);
            db.ShippingDeliveries.Remove(shippingDelivery);
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
