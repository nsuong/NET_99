using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace myweb.Models
{
    public class SinhVien
    {
        public int Id { get; set; }
        [Key]
        public string MaSv { get; set; }
        public string HoTen { get; set; }
        public string Lop { get; set; }
        public DateTime NgaySinh { get; set; }

    }
}
