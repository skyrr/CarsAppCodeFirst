using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace CarsAppCF.Models.TravelModel
{
    public class CarType
    {
        public CarType()
        {
            this.Cars = new HashSet<Car>();
        }
        [Key]
        public int CarTypeId { get; set; }
        public string CarTypeName { get; set; }

        public virtual ICollection<Car> Cars { get; set; }
    }
}