using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace SinhVien.Models
{
    public class SinhVient
    {
        [Key]
        [Required]
        [Display(Name ="Mã sinh viên")]
        public string MaSV { get; set; }
        [Required]
        [Display(Name ="Tên sinh viên")]
        public string TenSV { get; set; }

        [Display(Name ="Ngày sinh")]
        public DateTime NgaySinh { get; set; }

        [Display(Name ="Địa chỉ")]
        public DateTime DiaChi { get; set; }

        [Display(Name ="Khoa")]
        public string MaKhoa { get; set; }
        [ForeignKey("MaKhoa")]
        public Khoa Khoa { get; set; }

        [Display(Name ="Môn học")]
        public string MaMon { get; set; }
        [ForeignKey("MaMon")]
        public MonHoc MonHoc { get; set; }
        
    }
}
