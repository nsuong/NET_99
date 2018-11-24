using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace myweb.Models
{
    public class Khoa
    {
        public int Id { get; set; }
        [Key]
        public int MaKhoa { get; set; }
        public string TenKhoa { get; set; }
    }
}
