using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2Lab2Sem_Csharp_
{
    public class Person
    {
        private string firstName;
        private string lastName;
        private DateTime dateOfBirth;

        public string FirstName
        {
            get => firstName;
            set => firstName = value;
        }
        public string LastName
        {
            get => lastName;
            set => lastName = value;
        }

        public DateTime DateOfBirth
        {
            get =>  dateOfBirth; 
            set => dateOfBirth = value; 
        }
        public int YearOfBirth
        {
            get => dateOfBirth.Year;
            set => dateOfBirth = dateOfBirth.AddYears(value - dateOfBirth.Year); 
        }
        public Person(string firstname, string lastName, DateTime DateOfBirth)
        {
            FirstName = firstname;
            LastName = lastName;
            this.DateOfBirth = DateOfBirth;
        }
        
            public Person()
        {
            firstName = "Ivan";
            lastName = "Fedorov";
            DateOfBirth = new DateTime(2000, 01, 20);
        }
        public override string ToString()
        {
            return $"Firstname: {firstName}, lastname: {lastName}, date of borning: {DateOfBirth.ToShortDateString()}." ;
        }
        public virtual string ToShortString()
        {
            return $"Firstname: {firstName}, lastname: {lastName}. ";

        }
    }
}
