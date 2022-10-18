﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Laborator_2.Data;
using Laborator_2.Models;

namespace Laborator_2.Pages.Books
{
    public class IndexModel : PageModel
    {
        private readonly Laborator_2.Data.Laborator_2Context _context;

        public IndexModel(Laborator_2.Data.Laborator_2Context context)
        {
            _context = context;
        }

        public IList<Book> Book { get;set; } = default!;

        public async Task OnGetAsync()
        {
            Book = await _context.Book
                .Include(b=>b.Publisher)
                .ToListAsync();
        }
    }
}
