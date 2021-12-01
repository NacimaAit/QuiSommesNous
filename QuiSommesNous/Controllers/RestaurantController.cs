using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using QuiSommesNous.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace QuiSommesNous.Controllers
{
    
    public class RestaurantController : Controller
    {
        static private List<Plat> plats = new List<Plat>()
    {
        new Plat (1,"Couscous", 50, "Oriental", "Fortement"),
        new Plat (2,"Suchi", 40, "Asuatique", "Moyennement"),
        new Plat (3,"Poulet Grec", 30, "Greque", "Faible"),
        new Plat (4,"Soupe", 50, "asiatique", "Fortement"),
    };
        // GET: RestaurantController
        public ActionResult Index()
        {
            return View(plats);
        }

        // GET: RestaurantController/Details/5
        public ActionResult Details(int Id)
        {
            Plat detail = plats.Find(p => p.Id == Id);

            return View(detail);
        }

        // GET: RestaurantController/Create
        public ActionResult Create()
        {
            Plat  creer = new Plat();

            return View(creer);
        }

        // POST: RestaurantController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Plat creer)
        {
            try
            {
                //ajouter un nouvelle enregistrement a la liste creer (plats)
                plats.Add(creer);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: RestaurantController/Edit/5
        public ActionResult Edit(int Id)
        {
            Plat Edition = plats.Find(p => p.Id == Id);//chercher l identifiant

            return View(Edition);
        }

        // POST: RestaurantController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int Id, Plat Edition)
        {
            try

            {
                var old = plats.Find(p => p.Id == Edition.Id);
                plats.Remove(old);
                plats.Add(Edition);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: RestaurantController/Delete/5
        public ActionResult Delete(int Id)
        {
            Plat supp = plats.Find(p => p.Id == Id);

            return View(supp);
        }

        // POST: RestaurantController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int Id, Plat supp)
        {
            try
            {
                var old = plats.Find(p => p.Id == supp.Id);
                plats.Remove(old);
                
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
