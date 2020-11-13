using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace px_m2_nguyenthanhdat.Models
{
    public class Book
    {
        public int Id { get; set; }
        public string ImageUrl { get; set; }
        public string Name { get; set; }
        public string Author { get; set; }
        public string Description { get; set; }
        public int YearReleased { get; set; }
        public int Stock { get; set; }
        public int CategoryId { get; set; }
        public Category Category { get; set; }
    }
}
