using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using SaleWebMVC.Models;

namespace SaleWebMVC.Data
{
    public class SaleWebMVCContext : DbContext
    {
        public SaleWebMVCContext (DbContextOptions<SaleWebMVCContext> options)
            : base(options)
        {
        }

        public DbSet<Department> Department { get; set; }
        public DbSet<Saller> Saller { get; set; }
        public DbSet<SalesRecord> SalesRecords { get; set; }

    }
}
