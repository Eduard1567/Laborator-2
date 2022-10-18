using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Laborator_2.Data;
using Laborator_2.Models;

namespace Laborator_2.Pages.Publishers
{
    public class IndexModel : PageModel
    {
        private readonly Laborator_2.Data.Laborator_2Context _context;

        public IndexModel(Laborator_2.Data.Laborator_2Context context)
        {
            _context = context;
        }

        public IList<Publisher> Publisher { get;set; } = default!;

        public async Task OnGetAsync()
        {
            if (_context.Publisher != null)
            {
                Publisher = await _context.Publisher.ToListAsync();
            }
        }
    }
}
