using LeHuuToan_2001206939_LTW.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Diagnostics.CodeAnalysis;
using static System.Net.Mime.MediaTypeNames;
using System.IO;
using System.Linq;

namespace LeHuuToan_2001206939_LTW.Controllers
{
    public class BookController : Controller
    {
        public IActionResult Index()
        {
            return View(Books.ListBook);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create([Bind("Name, Price")] Book book, IFormFile file = null)
        {
            book.Guid = Guid.NewGuid();
            if(file != null)
            {
                string ImageName = Guid.NewGuid().ToString() + Path.GetExtension(file.FileName);
                string SavePath = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/img", ImageName);
                using (var stream = new FileStream(SavePath, FileMode.Create))
                {
                    file.CopyTo(stream);
                }
                book.Img = ImageName;

            }
            if (!ModelState.IsValid)
                return View(book);
            Books.ListBook.Add(book);
            return RedirectToAction("index", "book");
        }

        [HttpPost]
        public IActionResult Delete(Guid id)
        {
            Books.ListBook = Books.ListBook.Where(b => b.Guid != id).ToList();
            return RedirectToAction("index", "book");
        }


    }
}
