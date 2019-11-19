using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentCar.ORM.Entity
{
    public class Musteri:BaseEntity
    {
        
        [Required]
        public string Tc { get; set; }
        [Required]
        public string Ad { get; set; }
        [Required]
        public string Soyad { get; set; }
        [Required]
        public string Telefon { get; set; }
        [Required]
        public string EhliyetNo { get; set; }
        [Required]
        public string Adres { get; set; }
        [Required]
        public string Email { get; set; }
        [Required]
        public string Sifre { get; set; }

        
        


        public List<Araba> Arabalar { get; set; }//mapping --varlık ilişkisi
    }
}
