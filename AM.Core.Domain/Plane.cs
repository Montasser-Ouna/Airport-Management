using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AM.Core.Domain
{
    public enum planeType
    {
        Boing , Airbus
    }
    public class Plane
    {
        [Range(0, int.MaxValue, ErrorMessage = "entier positive")]
        public int Capacity { get; set; }

        public DateTime ManufactureDate
        { get; set; }
        public int PlaneId { get; set; }
        public planeType PlaneType { get; set; }
            
        public virtual IList<Flight> Flights { get; set; }
        public override string ToString()
        {
            return "Capacity:" + Capacity + ";"
                + "ManufactureDate:" + ManufactureDate + ";"
                + "PlaneId:" + PlaneId + ";"
                + "planeType:" + PlaneType;
        }
        public Plane()
        {

        }
        public Plane(planeType pt, int capacity, DateTime date)
        {
            Capacity = capacity;// on peut utiliser  this.Capacity = capacity; ou sans this (pour distinguer les noms)
            ManufactureDate = date;
            PlaneType = pt;
        }
    }
}
