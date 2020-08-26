using SaleWebMVC.Data;
using SaleWebMVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SaleWebMVC.Services
{
    public class SallerService
    {
        private readonly SaleWebMVCContext _context;

        public SallerService(SaleWebMVCContext context)
        {
            _context = context;
        }

        public List<Saller> FindAll()
        {
            return _context.Saller.ToList();
        }

    }
}
