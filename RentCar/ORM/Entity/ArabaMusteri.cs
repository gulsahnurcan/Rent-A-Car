using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentCar.ORM.Entity
{
    public class ArabaMusteri:BaseEntity
    {
        public int ArabaId { get; set; }
        public virtual Araba Araba { get; set; }//Mapping

        public int MusteriId { get; set; }
        public virtual Musteri Musteri { get; set; }//Mapping

        public DateTime AlisTarihi { get; set; }
        public DateTime TeslimTarihi { get; set; }
        public int KiralanmaSuresi { get; set; }
        public double Tutar { get; set; }
        
        
    }
}
