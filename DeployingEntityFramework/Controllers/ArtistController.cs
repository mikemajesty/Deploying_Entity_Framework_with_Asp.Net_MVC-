using DeployingEntityFramework.Models;
using DeployingEntityFramework.Models.Repository;
using System.Web.Mvc;

namespace DeployingEntityFramework.Controllers
{
    public class ArtistController : Controller
    {
        public ArtistRepository db { get; set; } = new ArtistRepository();

        public ActionResult Index()
        {
            return View(db.GetAll());
        }
        public ActionResult Create()
               => View();
        [HttpPost]
        public ActionResult Create(Artist artist)
        {
            if (ModelState.IsValid)
            {
                db.Add(artist);
                db.SaveChanges();
                return RedirectToAction(nameof(this.Index));
            }
            return View(artist);
        }

    }
}