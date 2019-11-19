using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentCar.ORM.Entity
{
    public class BaseEntity
    {
        [Required]
        public int ID { get; set; }
        public DateTime? AddDate { get; set; }
        public DateTime? UpdateDate { get; set; }
        public DateTime? DeletedDate { get; set; }
        [Required]
        public bool AktifMi { get; set; }
    }
}
