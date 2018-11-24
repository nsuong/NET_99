using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace myweb.Models
{
    public class MonHoc
    {
        public int Id { get; set; }
        [Key]
        public string MaMon { get; set; }
        public string TenMon { get; set; }
        [Range(1,5)]
        public int SoTC { get; set; }

    }
}
