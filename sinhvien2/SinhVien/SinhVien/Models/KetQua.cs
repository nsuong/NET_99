using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace SinhVien.Models
{
    public class KetQua
    {
        [Key]
        public string MaKQ { get; set; }

        [Display(Name ="Môn học")]
        public string MaMon { get; set; }
        [ForeignKey("MaMon")]
        public MonHoc MonHoc { get; set; }

        [Display(Name = "Điểm")]
        public float Diem { get; set; }

        [Display(Name ="Sinh viên")]
        public string MaSV { get; set; }
        [ForeignKey("MaSV")]
        public SinhVient SinhVien { get; set; }
    }
}
