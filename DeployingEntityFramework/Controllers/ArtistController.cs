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
            //var listSolo = db.GetSoloArtist();
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
        public ActionResult Details(int id)
        {
            Artist artist = db.GetByID(id);            
            return artist != null ? View(artist) : (ActionResult)HttpNotFound();
        }
    }
}