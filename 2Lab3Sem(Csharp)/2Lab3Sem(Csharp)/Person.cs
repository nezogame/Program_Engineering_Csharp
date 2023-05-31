using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2Lab3Sem_Csharp_
{
    public class Person : IDateAndCopy
    {
        public void Move()
        {
            Console.WriteLine("Person Move");
        }

        protected string firstName;
        protected string lastName;
        protected DateTime date;

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

        public DateTime Date
        {
            get => date;
            set => date = value;
        }
        public int YearOfBirth
        {
            get => date.Year;
            set => date = date.AddYears(value - date.Year);
        }

        public Person(string firstname, string lastName, DateTime DateOfBirth)
        {
            FirstName = firstname;
            LastName = lastName;
            this.date = DateOfBirth;
        }

        public Person()
        {
            firstName = "Ivan";
            lastName = "Fedorov";
            date = new DateTime(2000, 01, 20);
        }
        public override string ToString()
        {
            return $"Firstname: {firstName}, lastname: {lastName}, date of borning: {date.ToShortDateString()}.";
        }
        public virtual string ToShortString()
        {
            return $"Firstname: {firstName}, lastname: {lastName}. ";

        }
        public override bool Equals(object obj)
        {
            if (obj != null && obj.ToString() == this.ToString())
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public static bool operator ==(Person first, Person second)
        {
            return first.Equals(second);
        }
        public static bool operator !=(Person first, Person second)
        {
            return !first.Equals(second);
        }
        public override int GetHashCode()
        {
            return ToString().GetHashCode();
        }
        public virtual object DeepCopy()
        {
            Person deepCopy = (Person)this.MemberwiseClone();
            return deepCopy;
        }
    }
}
