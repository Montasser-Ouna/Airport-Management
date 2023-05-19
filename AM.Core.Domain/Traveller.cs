using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AM.Core.Domain
{
    public class Traveller : Passenger
    {
        public string HealthInformation { get; set; }
        public string Nationality { get; set; }


        public override string ToString()
        {
            return base.ToString() //l'appellation de la classe passenger
                + "HealthInformation:" + HealthInformation + ";"
                + "Nationality:" + Nationality;
        }
        public override string GetPassengerType()
        {
           // return base.GetPassengerType() // elle affiche I m passanger
               return  " I am a traveller ";
        }
    }
}
