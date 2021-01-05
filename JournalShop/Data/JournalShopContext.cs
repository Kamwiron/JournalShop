using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using JournalShop.Models;

namespace JournalShop.Data
{
   public class JournalShopContext : DbContext
    {
        public JournalShopContext(DbContextOptions<JournalShopContext> options)
            : base(options)
        {
        }

        public DbSet<Journal> Journal { get; set; }
    }
}
