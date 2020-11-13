using px_m2_nguyenthanhdat.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace px_m2_nguyenthanhdat.ViewModels
{
    public class HomeIndexVM
    {
        public List<Book> Books { get; set; }
        public IEnumerable<Category> Categories { get; set; }
    }
}
