using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace CarsAppCF.Models.TravelModel
{
    public class Travel
    {
        [Key]
        public int TravelId { get; set; }
        public string TravelName { get; set; }
        public int DirectionId { get; set; }
        public int CarId { get; set; }
        public DateTime TravelDate { get; set; }

        public virtual Direction Direction { get; set; }
        public virtual Car Car { get; set; }
    }
}