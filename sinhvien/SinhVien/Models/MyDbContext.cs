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
        public DbSet<SinhVient> SinhViens { get; set; }
        public DbSet<MonHoc> MonHocs { get; set; }
        public DbSet<KetQua> KetQuas { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {

            optionsBuilder.UseSqlServer(@"Server=.;Database=EFCoreCodeFirstQLBH;Integrated Security=True;");
        }
        public MyDbContext(DbContextOptions<MyDbContext> options) : base(options)
        {
        }
        public MyDbContext()
        {

        }
    }
}
