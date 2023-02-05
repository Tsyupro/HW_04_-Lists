using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_04__Lists
{
    internal class Person
    {
        internal int id;
        internal string Name;
        internal string Last_Name;
        private string Country;
        private DateTime Date_of_birth;
        private string Sex;
        private static int s_id=0;

        public Person(string name, string last_Name,string country, DateTime date_of_birth, string sex)
        {
            Name = name;
            Last_Name = last_Name;
            Country = country;
            Date_of_birth = date_of_birth;
            Sex = sex;
            id= s_id;
            s_id++;
        }
        public string GetInfo() {          
           return $"Імя: {Name} Прізвище: {Last_Name} Країна,місто: {Country} Дата народження: {Date_of_birth.ToLongDateString()} Стать: {Sex} ";
        }
        public override string ToString()
        {
            return $"Імя: {Name} Прізвище: {Last_Name}";
        }
    }
}
