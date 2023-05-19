using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace AM.Core.Domain
{
    public class Passenger
    {

        // public int Id { get; set; }
        [Display(Name = "Date of Birth")]
        public DateTime BirthDate { get; set; }
        [Key]
        [MinLength(7, ErrorMessage = "MinLength 7")]
        [MaxLength(7, ErrorMessage = "MaxLength 7")]
        public string PassportNumber { get; set; }

        [EmailAddress(ErrorMessage = "une address email invalid .")]
        public string EmailAdress { get; set; }
        //  [MinLength(3, ErrorMessage = "MinLength 3")]
        //[MaxLength(25, ErrorMessage = "MaxLength 25")]
        //public string FirstName { get; set; }

        //public string LastName { get; set; }
        public  FullName MyFullName { get; set; }
        [Phone(ErrorMessage = "une numero invalid .")]
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
            + "FirstName:" + MyFullName.Firstname + ";"
            + "LastName:" + MyFullName.Lastname + ";"
             + "TelNumber:" + TelNumber;



        }
        public bool CheckProfile(string lastName, string firstName, string emailAdress = null)
        {
            if (emailAdress == null)
                return lastName == MyFullName.Lastname && firstName == MyFullName.Firstname;
            else
                return lastName == MyFullName.Lastname && firstName == MyFullName.Firstname && emailAdress == EmailAdress;
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
