using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using px_m2_nguyenthanhdat.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace px_m2_nguyenthanhdat.Controllers
{
    public class CategoryController : Controller
    {
        private readonly AppDbContext _appDbContext;

        public CategoryController(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }
        public IActionResult Index()
        {
            IEnumerable<Category> categories = _appDbContext.Categories.Include(p => p.Books);

            return View(categories);
        }
    }
}