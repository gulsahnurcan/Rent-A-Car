using RentCar.ORM.Entity;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentCar.ORM.Context
{
    public class ProjeContext:DbContext
    {
        public ProjeContext()
        {
            Database.Connection.ConnectionString = "Server=404-Y03; Database=RentACar; uid=sa; pwd=1234;";
        }
       
        public DbSet<Araba> TBLAraba { get; set; }
        public DbSet<Musteri> TBLMusteri { get; set; }
        public DbSet<ArabaMusteri> TBLArabaMusteri { get; set; }
        public DbSet<Kullanici> TBLKullanici { get; set; }
    }
}
