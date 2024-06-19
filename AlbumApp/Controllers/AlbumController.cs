using AlbumApp.Entities;
using Microsoft.AspNetCore.Mvc;

namespace AlbumApp.Controllers
{
    public class AlbumController : Controller
    {
        private readonly AlbumsDbContext _context;
        public AlbumController(AlbumsDbContext context)
        {
            _context = context;
        }
        public IActionResult List()
        {
            var albums = _context?.Albums?.OrderByDescending(x => x.Rating).ToList();
            return View(albums);
        }
        [HttpGet]
        public IActionResult Create()
        {

            return View(new Album());
        }
        [HttpPost]
        public IActionResult Create(Album album)
        {
            if (ModelState.IsValid)
            {
                _context?.Albums?.Add(album);
                _context?.SaveChanges();
                return RedirectToAction("List");
            }

            return View(album);
        }
        [HttpGet]
        public IActionResult Edit(int id)
        {
            var album = _context?.Albums?.Find(id);
            if (album == null)
            {
                return NotFound(); // Return 404 if the measurement is not found
            }
            return View(album);
        }

        [HttpPost]
        public IActionResult Edit(Album album)
        {
            if (ModelState.IsValid)
            {
                if (album.Id == 0)
                {
                    _context?.Albums?.Add(album);
                }
                else
                {
                    _context?.Albums?.Update(album);
                }

                _context?.SaveChanges();
                return RedirectToAction("List");
            }
            else
            {
                return View(album);
            }
        }
        [HttpGet]
        public IActionResult ViewDetails(int id)
        {
            var album = _context?.Albums?.Find(id);
            if (album == null)
            {
                return NotFound(); // Return 404 if the measurement is not found
            }
            return View(album);
        }

        public IActionResult Items()
        {
            return View();
        }
    }
}
