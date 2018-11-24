using SinhVien.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SinhVien.ViewModels
{
    public class createDiem
    {
        public KetQua ketQua { get; set; }

        public IEnumerable<listMonHoc>monHoc{get;set;}
        public createDiem(string id)
        {
            ketQua = new KetQua() { MaSV = id };
            List<listMonHoc> arr1 = new List<listMonHoc>();
            using (var context = new MyDbContext())
            {
                context.MonHocs.ToList().ForEach(
                    p =>
                    {
                        arr1.Add(new listMonHoc(p.MaMon, p.TenMmon, p.SoTinChi));
                    });
            }
            monHoc = arr1;
        }
        public createDiem()
        {
            List<listMonHoc> arr1 = new List<listMonHoc>();
            using (var context = new MyDbContext())
            {
                context.MonHocs.ToList().ForEach(
                    p =>
                    {
                        arr1.Add(new listMonHoc(p.MaMon, p.TenMmon, p.SoTinChi));
                    });
            }
            monHoc = arr1;
        }
    }
}
