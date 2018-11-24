using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SinhVien.Models;
using SinhVien.ViewModels;

namespace SinhVien.Controllers
{
    public class KetQuaController : Controller
    {
        private MyDbContext context;
        public KetQuaController()
        {
            context = new MyDbContext();
        }
        public IActionResult Index()
        {
            var sinhvien = context.SinhViens.ToList();
            return View(sinhvien);
        }
        public IActionResult read( string id) { 
            var diem = context.KetQuas.Where(m => m.MaSV.Equals(id)).ToList();
            var ten = context.SinhViens.SingleOrDefault(m => m.MaSV == id).TenSV;
            AddDiem add = new AddDiem(diem, id, ten);
            return View(add);
        }
        public IActionResult create(string id)
        {
            createDiem diem = new createDiem(id);
            return View(diem);
        }
        [HttpPost]
        public IActionResult create(createDiem khoa)
        {
            context.KetQuas.Add(khoa.ketQua);
            context.SaveChanges();
            return RedirectToAction("index", "KetQua");
        }
        public IActionResult delete(string id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            var khoa = context.KetQuas.SingleOrDefault(p => p.MaKQ == id);
            if (khoa == null)
            {
                return NotFound();
            }
            context.KetQuas.Remove(khoa);
            context.SaveChanges();
            return RedirectToAction("read", "Khoa");
        }
    }
}