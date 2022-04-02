using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using THi_PIIT_DANGVANTIEN.Data;
using THi_PIIT_DANGVANTIEN.Models;

namespace THi_PIIT_DANGVANTIEN.Areas.Admin.Controllers
{
    public class BitCoinsController : Controller
    {
        private BitCoinDBContext db = new BitCoinDBContext();

        // GET: Admin/BitCoins
        public ActionResult Index()
        {
            return View(db.BitCoins.ToList());
        }

        // GET: Admin/BitCoins/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            BitCoin bitCoin = db.BitCoins.Find(id);
            if (bitCoin == null)
            {
                return HttpNotFound();
            }
            return View(bitCoin);
        }

        // GET: Admin/BitCoins/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Admin/BitCoins/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,Name,baseAsset,quoteAsset,lastPrice,volumn24h,marketId,createdAt,updatedAt,status")] BitCoin bitCoin)
        {
            if (ModelState.IsValid)
            {
                db.BitCoins.Add(bitCoin);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(bitCoin);
        }

        // GET: Admin/BitCoins/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            BitCoin bitCoin = db.BitCoins.Find(id);
            if (bitCoin == null)
            {
                return HttpNotFound();
            }
            return View(bitCoin);
        }

        // POST: Admin/BitCoins/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,Name,baseAsset,quoteAsset,lastPrice,volumn24h,marketId,createdAt,updatedAt,status")] BitCoin bitCoin)
        {
            if (ModelState.IsValid)
            {
                db.Entry(bitCoin).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(bitCoin);
        }

        // GET: Admin/BitCoins/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            BitCoin bitCoin = db.BitCoins.Find(id);
            if (bitCoin == null)
            {
                return HttpNotFound();
            }
            return View(bitCoin);
        }

        // POST: Admin/BitCoins/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            BitCoin bitCoin = db.BitCoins.Find(id);
            db.BitCoins.Remove(bitCoin);
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
