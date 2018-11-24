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
            context.SinhViens.Add(sinhVien);
            context.SaveChanges();
            return RedirectToAction("Index", "SinhVien");
        }
        public IActionResult edit(string id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            CreateSinhVienViewModels sinhvien = new CreateSinhVienViewModels();
            sinhvien.sinhVien=context.SinhViens.SingleOrDefault(p => p.MaSV == id);
            List<listKhoa> arr = new List<listKhoa>();
            context.Khoas.ToList().ForEach(
                    p =>
                    {
                        arr.Add(new listKhoa(p.MaKhoa, p.TenKhoa));
                    });
            sinhvien.khoa = arr;
            List<listMonHoc> arr1 = new List<listMonHoc>();
            context.MonHocs.ToList().ForEach(
                    p =>
                    {
                        arr1.Add(new listMonHoc(p.MaMon, p.TenMmon, p.SoTinChi));
                    });
            sinhvien.monHoc = arr1;
            if (sinhvien.sinhVien == null)
            {
                return NotFound();
            }
            return View(sinhvien);
        }
        [HttpPost]
        public IActionResult edit(SinhVient sinhvien)
        {
            context.SinhViens.Update(sinhvien);
            context.SaveChanges();
            return RedirectToAction("Index", "SinhVien");
        }
        public IActionResult delete(string id)
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
            context.SinhViens.Remove(khoa);
            context.SaveChanges();
            return RedirectToAction("Index", "SinhVien");
        }
    }
}