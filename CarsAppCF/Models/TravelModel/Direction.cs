using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace CarsAppCF.Models.TravelModel
{
    public class Direction
    {
        public Direction()
        {
            this.Travels = new HashSet<Travel>();
        }
        [Key]
        public int DirectionId { get; set; }
        public string DirectionName { get; set; }
        public int DepartureId { get; set; }
        public int DestinationId { get; set; }
        public double Distance { get; set; }

        public virtual Point Point { get; set; }
        public virtual Point Point1 { get; set; }
        public virtual ICollection<Travel> Travels { get; set; }
    }
}