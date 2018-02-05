using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace CarsAppCF.Models.TravelModel
{
    public class Car
    {
        public Car()
        {
            this.Travels = new HashSet<Travel>();
        }
        [Key]
        public int CarId { get; set; }
        public string CarName { get; set; }
        public int CarTypeId { get; set; }
        public double Consumption { get; set; }

        public CarType CarType { get; set; }
        public virtual ICollection<Travel> Travels { get; set; }
    }
}