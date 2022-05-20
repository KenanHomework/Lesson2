using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp1.Task_1
{
    public class Human
    {
        public Human(string name, string surname, string parentName, DateTime birthDate, string phone, string country, string city, string gender)
        {
            Name = name;
            Surname = surname;
            ParentName = parentName;
            BirthDate = birthDate;
            Phone = phone;
            Country = country;
            City = city;
            Gender = gender;
        }

        public string Name { get; set; }

        public string Surname { get; set; }

        public string ParentName { get; set; }

        public DateTime BirthDate { get; set; }

        public string Phone { get; set; }

        public string Country { get; set; }

        public string City { get; set; }

        public string Gender { get; set; }
    }
}
