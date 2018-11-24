using SinhVien.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SinhVien.ViewModels
{
    public class AddDiem
    {
        public IEnumerable<KetQua> ketQua { get; set; }

        public string maSV { get; set; }
        public string tenSv { get; set; }
        public AddDiem(List <KetQua> ketqua, string masv, string ten)
        {
            this.ketQua = ketqua;
            maSV = masv;
            tenSv = ten;
        }
    }
}
