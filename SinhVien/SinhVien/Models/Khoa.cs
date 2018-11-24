using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SinhVien.Models
{
    public class Khoa
    {
        [Key]
        public string MaKhoa { get; set; }

        [Required]
        [Display(Name ="Tên Khoa")]
        public string TenKhoa { get; set; }
    }
}
