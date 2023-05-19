using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace AM.Core.Domain
{
    public class Passenger
    {
        public DateTime BirthDate { get; set; }

        public string PassportNumber { get; set; }
        public string EmailAdress { get; set; }
        public string FirstName { get; set; }
      
        public string LastName { get; set; }
        public int TelNumber { get; set; }
        int age;
        public int Age //ecriture full si j'ai un traitement à faire dans get
        {
            get
            {
                DateTime now = DateTime.Now;
                age = now.Year - BirthDate.Year;
                if (now < BirthDate.AddYears(age)) //comparer now avec le futur anniversaire
                {
                    age--;
                }
                return age;
            }
        }
        public override string? ToString()
        {
            return "BirthDate:" + BirthDate + ";"
            + "PassportNumber:" + PassportNumber + ";"
            + "EmailAdress:" + EmailAdress + ";"
            + "FirstName:" + FirstName + ";"
            + "LastName:" + LastName + ";"
             + "TelNumber:" + TelNumber;



        }
        public bool CheckProfile(string lastName, string firstName, string emailAdress = null)
        {
            if (emailAdress == null)
                return lastName == LastName && firstName == FirstName;
            else
                return lastName == LastName && firstName ==FirstName && emailAdress == EmailAdress;
        }


        public virtual string GetPassengerType()
        {
            return "I am a passenger";
        }

        public void GetAge(DateTime birthDate, ref int calculatedAge)
        {
            DateTime now = DateTime.Now;
            int age = now.Year - birthDate.Year;

            if (now < birthDate.AddYears(age))
            {
                age--;
            }

            calculatedAge = age;
        }
        // Autres propriétés et méthodes de la classe Passenger
        //public void GetAge(Passenger aPassenger)
        //{
        //    DateTime now = DateTime.Now;
        //    int age = now.Year - aPassenger.BirthDate.Year;

        //    if (now < BirthDate.AddYears(age))
        //    {
        //        age--;
        //    }

        //    aPassenger.Age = age;
        //}

    }
}
