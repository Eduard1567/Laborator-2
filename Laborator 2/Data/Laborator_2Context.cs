using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Laborator_2.Models;

namespace Laborator_2.Data
{
    public class Laborator_2Context : DbContext
    {
        public Laborator_2Context (DbContextOptions<Laborator_2Context> options)
            : base(options)
        {
        }

        public DbSet<Laborator_2.Models.Book> Book { get; set; } = default!;

        public DbSet<Laborator_2.Models.Publisher> Publisher { get; set; }
    }
}
