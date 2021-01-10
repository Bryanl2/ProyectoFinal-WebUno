using Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess
{
    public class CellphoneContext : DbContext
    {
        public DbSet<CellphoneEntity> Cellphones { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            if (!options.IsConfigured)
            {
                options.UseSqlServer("Server=DESKTOP-D2D20OV\\SQLEXPRESS01; Database=ParcialFinalWebUno; User Id=Bryan; Password=123");
            }
        }

        //Se agregan datos semilla OnModelCreating
        protected override void OnModelCreating(ModelBuilder mB)
        {
            base.OnModelCreating(mB);
            mB.Entity<CellphoneEntity>().HasData(
                new CellphoneEntity
                {
                    Id = "HWE",
                    Model = "Huawei 34P",
                    Brand = "Huawei",
                    Color = "red",
                    Status = "ACTIVO"
                },
                 new CellphoneEntity
                 {
                     Id = "HW3E",
                     Model = "Huawei 569CO",
                     Brand = "Huawei",
                     Color = "blue",
                     Status = "ACTIVO"
                 }
                );
        }
    }
}
