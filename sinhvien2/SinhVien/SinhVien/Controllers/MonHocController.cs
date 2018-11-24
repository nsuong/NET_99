using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SinhVien.Models;

namespace SinhVien.Controllers
{
    public class MonHocController : Controller
    {
        private MyDbContext context;
        public MonHocController()
        {
            context = new MyDbContext();
        }
        public IActionResult Index()
        {
            var khoa = context.MonHocs.ToList();
            return View(khoa);
        }
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(MonHoc monHoc)
        {
            context.MonHocs.Add(monHoc);
            context.SaveChanges();
            return RedirectToAction("Index", "MonHoc");
        }
        public IActionResult edit(string id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            var monHoc = context.MonHocs.SingleOrDefault(p => p.MaMon == id);
            if (monHoc == null)
            {
                return NotFound();
            }
            return View(monHoc);
        }
        [HttpPost]
        public IActionResult edit(MonHoc monHoc)
        {
            context.MonHocs.Update(monHoc);
            context.SaveChanges();
            return RedirectToAction("Index", "MonHoc");
        }
        public IActionResult delete(string id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            var monHoc = context.MonHocs.SingleOrDefault(p => p.MaMon == id);
            if (monHoc== null)
            {
                return NotFound();
            }
            context.MonHocs.Remove(monHoc);
            context.SaveChanges();
            return RedirectToAction("Index", "MonHoc");
        }
    }
}