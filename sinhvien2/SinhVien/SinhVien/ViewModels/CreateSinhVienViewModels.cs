using SinhVien.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SinhVien.ViewModels
{
    public class CreateSinhVienViewModels
    {
        public SinhVient sinhVien { get; set; }
        public IEnumerable<listKhoa> khoa { get; set; }
        public IEnumerable<listMonHoc> monHoc { get; set; }

        public CreateSinhVienViewModels()
        {
            List<listKhoa> arr = new List<listKhoa>();
            using (var context = new MyDbContext())
            {
                context.Khoas.ToList().ForEach(
                    p =>
                    {
                        arr.Add(new listKhoa(p.MaKhoa, p.TenKhoa));
                    });
            }
            this.khoa = arr;
            List<listMonHoc> arr1 = new List<listMonHoc>();
            using (var context = new MyDbContext())
            {
                context.MonHocs.ToList().ForEach(
                    p =>
                    {
                        arr1.Add(new listMonHoc(p.MaMon,p.TenMmon,p.SoTinChi));
                    });
            }
            this.monHoc = arr1;
        }
    }
}
