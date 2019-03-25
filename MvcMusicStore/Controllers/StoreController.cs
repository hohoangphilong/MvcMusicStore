using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MvcMusicStore.Models;

namespace MvcMusicStore.Controllers
{
    public class StoreController : Controller
    {
        // GET: Store
        public ActionResult Index()
        {
            var genres = new List<string> { "Rock", "Jazz", "Country", "Pop", "Disco" };
            var viewModal = new StoreIndexViewModal
            {
                NumberOfGenres = genres.Count(),
                Genres = genres
            };
            ViewBag.Starred = new List<string> { "Rock", "Jazz" };
            ViewBag.Message = "Your Store page";
            return View(viewModal);
        }
        public ActionResult Browse(string genre)
        {
            var genreModel = new Genre()
            {
                Name = genre
            };

            var albums = new List<Album>()
            {
                 new Album() { Title = genre + " Album 1" },
                 new Album() { Title = genre + " Album 2" }
            };

            var viewModel = new StoreBrowseViewModel()
            {
                Genre = genreModel,
                Albums = albums
            };

            return View(viewModel);
        }
        public ActionResult Details(int id)
        {
            var album = new Album { Title = "Sample Album" };

            return View(album);
        }
    }
}