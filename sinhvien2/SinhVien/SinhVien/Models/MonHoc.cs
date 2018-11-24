using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace SinhVien.Models
{
    public class MonHoc
    {
        [Key]
        public string MaMon { get; set; }

        [Display(Name ="Tên môn học")]
        public string TenMmon { get; set; }

        [Display(Name ="Số tín chỉ")]
        public int SoTinChi { get; set; }

    }
}
