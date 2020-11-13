using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using px_m2_nguyenthanhdat.Models;
using px_m2_nguyenthanhdat.ViewModels;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;

namespace px_m2_nguyenthanhdat.Controllers
{
    public class BookController : Controller
    {
        private readonly AppDbContext _appDbContext;
        private readonly IWebHostEnvironment _webHostEnvironment;

        public BookController(AppDbContext appDbContext, IWebHostEnvironment webHostEnvironment)
        {
            _appDbContext = appDbContext;
            _webHostEnvironment = webHostEnvironment;
        }
        public IActionResult Index()
        {


            var Books = _appDbContext.Books.Include(b => b.Category).ToList();
            return View(Books);
        }

        public IActionResult bookdetail()
        {
            var Books = _appDbContext.Books.Include(b => b.Category).ToList();
            return View();
        }
        public IActionResult Create()
        {

            BookCreateVM bookVM = new BookCreateVM()
            {
                Book = new Book(),
                CategorySelectList = _appDbContext.Categories.Select(item => new SelectListItem
                {
                    Text = item.CategoryName,
                    Value = item.Id.ToString()
                }),

            };
            return View(bookVM);
        }


        [HttpPost]
        public IActionResult Create(BookCreateVM bookCreateVM)
        {
            var files = HttpContext.Request.Form.Files;
            string webRootPath = _webHostEnvironment.WebRootPath;



            _appDbContext.Books.Add(bookCreateVM.Book);
            _appDbContext.SaveChanges();

            return RedirectToAction("Index");
        }

        public IActionResult Edit(int? id)
        {
            var book = _appDbContext.Books.Find(id);

            var selectList = new List<SelectListItem>();

            BookCreateVM bookVM = new BookCreateVM()
            {
                Book = _appDbContext.Books.FirstOrDefault(item => item.Id == id),
                CategorySelectList = _appDbContext.Categories.Select(item => new SelectListItem
                {
                    Text = item.CategoryName,
                    Value = item.Id.ToString()
                }),

            };

            return View(bookVM);
        }

        [HttpPost]
        public IActionResult Edit(BookCreateVM bookCreateVM)
        {
            var files = HttpContext.Request.Form.Files;
            string webRootPath = _webHostEnvironment.WebRootPath;

            var objProduct = _appDbContext.Books.AsNoTracking().FirstOrDefault(bo => bo.Id == bookCreateVM.Book.Id);


            _appDbContext.Books.Update(bookCreateVM.Book);
            _appDbContext.SaveChanges();

            return RedirectToAction("Index");
        }

        public IActionResult Delete(int? id)
        {
            if (id == null || id == 0)
            {
                return NotFound();
            }

            var Book = _appDbContext.Books.Find(id);
            if (Book == null) return NotFound();

            return View(Book);
        }

        [HttpPost]
        public IActionResult DeleteBook(int? id)
        {
            if (id == null || id == 0)
            {
                return NotFound();
            }

            var Book = _appDbContext.Books.Find(id);
            if (Book == null) return NotFound();

            _appDbContext.Books.Remove(Book);
            _appDbContext.SaveChanges();

            return RedirectToAction("Index");

        }
    }
}
