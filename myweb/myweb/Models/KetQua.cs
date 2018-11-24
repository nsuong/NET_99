using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace myweb.Models
{
    public class KetQua
    {
        public int Id { get; set; }
        public int MaKQ { get; set; }
        [Required]
        [Range(1,10)]
        public double Diem { get; set; }
        [ForeignKey("MaMon")]
        public string MaMon { get; set; }
        [ForeignKey("MaSv")]
        public string MaSv { get; set; }
    }
}
