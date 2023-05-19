using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AM.Core.Domain
{
    public class Staff : Passenger
    {
        public DateTime EmployementDate { get; set; }
        public string Function { get; set; }
        [DataType(DataType.Currency)]
        public string Salary { get; set; }
        public override string ToString()
        {
            return base.ToString() //l'appellation de la classe passenger
                + "EmployementDate:" + EmployementDate + ";"
                + "Function:" + Function + ";"
                + "Salary:" + Salary;
        }

        public override string GetPassengerType()
        {
            return base.GetPassengerType() // elle affiche I m passanger
                 + "I am a Staff Member";
        }
    }
}
