using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SinhVien.Models
{
    public class listKhoa
    {
        public string MaKhoa { get; set; }
        public string TenKhoa { get; set; }

        public listKhoa(string a, string b)
        {
            MaKhoa = a;
            TenKhoa = b;
        }
    }
}
