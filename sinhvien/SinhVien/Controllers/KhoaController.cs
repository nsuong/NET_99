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
            return RedirectToAction("Index", "Khoa");
        }
        public IActionResult edit(string id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            var khoa = context.Khoas.SingleOrDefault(p => p.MaKhoa == id);
            if (khoa == null)
            {
                return NotFound();
            }
            return View(khoa);
        }
        [HttpPost]
        public IActionResult edit(Khoa khoa)
        {
            context.Khoas.Update(khoa);
            context.SaveChanges();
            return RedirectToAction("Index", "Khoa");
        }
        public IActionResult delete(string id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            var khoa = context.Khoas.SingleOrDefault(p => p.MaKhoa == id);
            if (khoa == null)
            {
                return NotFound();
            }
            context.Khoas.Remove(khoa);
            context.SaveChanges();
            return RedirectToAction("Index", "Khoa");
        }
    }
}