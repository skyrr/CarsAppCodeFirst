using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace CarsAppCF.Models.TravelModel
{
    public class Point
    {
        public Point()
        {
            this.Directions = new HashSet<Direction>();
            this.Directions1 = new HashSet<Direction>();
        }
        [Key]
        public int PointId { get; set; }
        public string PointName { get; set; }

        public virtual ICollection<Direction> Directions { get; set; }
        public virtual ICollection<Direction> Directions1 { get; set; }
    }
}