using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace SinhVien.Models
{
    public class listMonHoc
    {
        public string MaMon { get; set; }

        public string TenMmon { get; set; }

        public int SoTinChi { get; set; }

        public listMonHoc(string a, string b, int c)
        {
            MaMon = a;
            TenMmon = b;
            SoTinChi = c;
        }
    }
}
