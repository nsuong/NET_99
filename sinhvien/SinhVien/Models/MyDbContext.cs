using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SinhVien.Models

{
    public class MyDbContext : DbContext
    {
        public DbSet<Khoa> Khoas { get; set; }
        public DbSet<SinhVien> SinhViens { get; set; }
        public DbSet<MonHoc> MonHocs { get; set; }
        public DbSet<KetQua> KetQuas { get; set; }
        public MyDbContext(DbContextOptions<MyDbContext> options) : base(options)
        {
        }
    }
}
