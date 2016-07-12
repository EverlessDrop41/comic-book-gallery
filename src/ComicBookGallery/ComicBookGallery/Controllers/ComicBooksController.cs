using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mvc;
using ComicBookGallery.Data;
using ComicBookGallery.Models;

namespace ComicBookGallery.Controllers
{
    public class ComicBooksController : Controller
    {
        private ComicBookRepository _comicBookRepository = null;

        public ComicBooksController()
        {
            _comicBookRepository = new ComicBookRepository();
        }

        public ActionResult Index()
        {
            var comicBooks = _comicBookRepository.GetComicBooks();

            return View(comicBooks);
        }

        public ActionResult Detail(int? id)
        {
            if (id.HasValue)
            {
                ComicBook comicBook = _comicBookRepository.GetComicBook(id.Value);

                if (comicBook != null)
                {
                    return View(comicBook);
                }
                return HttpNotFound();
            }

            return HttpNotFound();
        } 
    }
}
