using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Serb_Diana_Lab8.Models;

namespace Serb_Diana_Lab8.Data
{
    public class Serb_Diana_Lab8Context : DbContext
    {
        public Serb_Diana_Lab8Context (DbContextOptions<Serb_Diana_Lab8Context> options)
            : base(options)
        {
        }

        public DbSet<Serb_Diana_Lab8.Models.Book> Book { get; set; }

        public DbSet<Serb_Diana_Lab8.Models.Publisher> Publisher { get; set; }

        public DbSet<Serb_Diana_Lab8.Models.Category> Category { get; set; }

        public DbSet<Serb_Diana_Lab8.Models.BookCategory> BookCategory { get; set; }
    }
}
