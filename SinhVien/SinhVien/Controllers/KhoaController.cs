using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SinhVien.Models;

namespace SinhVien.Controllers
{
    public class KhoaController : Controller
    {
        private MyDbContext context;
        public KhoaController()
        {
            context = new MyDbContext();
        }
        public IActionResult Index()
        {
            var khoa = context.Khoas.ToList();
            return View(khoa);
        }
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(Khoa khoa)
        {
            context.Khoas.Add(khoa);
            context.SaveChanges();
            return View();
        }
    }
}