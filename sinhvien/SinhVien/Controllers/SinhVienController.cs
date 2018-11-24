using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SinhVien.Models;
using SinhVien.ViewModels;

namespace SinhVien.Controllers
{
    public class SinhVienController : Controller
    {
        private MyDbContext context;
        public SinhVienController()
        {
            context = new MyDbContext();
        }
        public IActionResult Index()
        {
            var sinhVien = context.SinhViens.ToList();
            return View(sinhVien);
        }
        public IActionResult create()
        {
            var sinhvien = new CreateSinhVienViewModels();
            return View(sinhvien);
        }
        [HttpPost]
        public IActionResult create(SinhVient sinhVien)
        {
            context.SinhViens.Update(sinhVien);
            context.SaveChanges();
            return RedirectToAction("Index", "SinhVien");
        }
        public IActionResult edit(string id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            var khoa = context.SinhViens.SingleOrDefault(p => p.MaSV == id);
            if (khoa == null)
            {
                return NotFound();
            }
            return View(khoa);
        }
        [HttpPost]
        public IActionResult edit(SinhVient khoa)
        {
            context.SinhViens.Update(khoa);
            context.SaveChanges();
            return RedirectToAction("Index", "SinhVien");
        }
        public IActionResult delete(string id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            var khoa = context.SinhViens.SingleOrDefault(p => p.MaKhoa == id);
            if (khoa == null)
            {
                return NotFound();
            }
            context.SinhViens.Remove(khoa);
            context.SaveChanges();
            return RedirectToAction("Index", "SinhVien");
        }
    }
}