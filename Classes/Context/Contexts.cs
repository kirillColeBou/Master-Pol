using Master_Pol.Classes.Model;
using Microsoft.EntityFrameworkCore;

namespace Master_Pol.Classes.Context
{
    public class Contexts : DbContext
    {
        public DbSet<Materials> Materials { get; set; }
        public DbSet<Partner_Products> Partner_Products { get; set; }
        public DbSet<Partners> Partners { get; set; }
        public DbSet<Products> Products { get; set; }
        public DbSet<Required_Material> Required_Material { get; set; }
        public DbSet<Suppliers> Suppliers { get; set; }
        public DbSet<Type_Partner> Type_Partner { get; set; }
        public DbSet<Type_Product> Type_Product { get; set; }

        public Contexts()
        {

        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) => optionsBuilder.UseSqlServer("Server=student.permaviat.ru;database=base2_ISP_21_2_23;uid=ISP_21_2_23;pwd=3frQxZ83o#");
    }
}
