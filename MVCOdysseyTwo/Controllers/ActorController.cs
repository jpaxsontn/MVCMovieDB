using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVCOdysseyTwo.Models;

namespace MVCOdysseyTwo.Controllers
{
    public class ActorController : Controller
    {
        // GET: Actor
        public ActionResult Index()
        {
            return View();
        }

        
        //Create a new actor 
        [HttpGet]
        public ActionResult Add()
        {
            Actor actor = new Actor();

            return View(actor);
        }
                
        [HttpPost]
        public ActionResult Add(Actor actorFromView)
        {
            if (ModelState.IsValid)
            {
                using (var db = new MovieDBContext())
                {
                    db.Actors.Add(actorFromView);
                    db.SaveChanges();
                }
                return RedirectToAction("Index");
            }
            return View(actorFromView);
        }

        //Edit
        
    }
}