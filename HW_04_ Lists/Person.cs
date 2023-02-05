using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_04__Lists
{
    internal class Person
    {
        internal string Name;
        internal string Last_Name;
        private string Country;
        private DateTime Date_of_birth;
        private string Sex;

        public Person(string name, string last_Name,string country, DateTime date_of_birth, string sex)
        {
            Name = name;
            Last_Name = last_Name;
            Country = country;
            Date_of_birth = date_of_birth;
            Sex = sex;
        }
        public string GetAllInfo() {
            return $"Імя: {Name} Прізвище: {Last_Name} Країна,місто: {Country} Дата народження: {Date_of_birth.ToLongDateString()} Стать: {Sex} ";
        } 

    }
}
