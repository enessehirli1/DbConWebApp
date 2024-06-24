using FAsgmntV2.Models;
using Microsoft.AspNetCore.Mvc;
using FAsgmntV2.Data;

namespace FAsgmntV2.Controllers
{
    public class SubscriberController : Controller
    {
        private readonly FAsgmntv2DbCon _db;
        public SubscriberController(FAsgmntv2DbCon db) 
        {
            _db = db;

        }

        public IActionResult Index()
        {
            IEnumerable<Subscriber> objSubscriberList = _db.Subscribers.ToList();
            return View(objSubscriberList);
        }

        public IActionResult Create() 
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]

        public IActionResult Create(Subscriber obj) 
        {
            _db.Subscribers.Add(obj);
            _db.SaveChanges();
            return RedirectToAction("Index");
        }

        public IActionResult Edit(int? id)
        {
            if(id == null)
            {
                return NotFound();
            }

            var subscriberFromDb = _db.Subscribers.Find(id);
            if(subscriberFromDb == null) 
            {
                return NotFound();  
            }
            return View(subscriberFromDb);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(Subscriber obj) 
        {
            if(ModelState.IsValid)
            {
                _db.Subscribers.Update(obj);
                _db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(obj);
            
        }

        public IActionResult Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var subscriberFromDb = _db.Subscribers.Find(id);
            if (subscriberFromDb == null)
            {
                return NotFound();
            }
            return View(subscriberFromDb);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Delete(Subscriber obj)
        {
     
            _db.Subscribers.Remove(obj);
            _db.SaveChanges();
            TempData["keyMessage"] = "Record Deleted Successfully !";
            return RedirectToAction("Index");
            

        }

    }
}
