using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SaleWebMVC.Services;

namespace SaleWebMVC.Controllers
{
    public class SallersController : Controller
    {
        private readonly SallerService _sallerService;

        public SallersController(SallerService sallerService)
        {
            _sallerService = sallerService;
        }

        public IActionResult Index()
        {
            var list = _sallerService.FindAll();
            return View(list);
        }
    }
}