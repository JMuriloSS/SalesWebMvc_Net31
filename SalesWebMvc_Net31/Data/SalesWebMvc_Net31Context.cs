using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using SalesWebMvc_Net31.Models;

namespace SalesWebMvc_Net31.Models
{
    public class SalesWebMvc_Net31Context : DbContext
    {
        public SalesWebMvc_Net31Context (DbContextOptions<SalesWebMvc_Net31Context> options)
            : base(options)
        {
        }

        public DbSet<Department> Department { get; set; }
        public DbSet<Seller> Seller { get; set; }
        public DbSet<SalesRecord> SalesRecord { get; set; }
    }
}
