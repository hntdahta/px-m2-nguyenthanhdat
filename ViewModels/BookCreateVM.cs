using Microsoft.AspNetCore.Mvc.Rendering;
using px_m2_nguyenthanhdat.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace px_m2_nguyenthanhdat.ViewModels
{
    public class BookCreateVM
    {
        public Book Book { get; set; }
        public IEnumerable<SelectListItem> CategorySelectList { get; set; }

    }
}
