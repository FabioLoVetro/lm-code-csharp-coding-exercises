using System;
namespace Exercises
{
    public class Exercise002
    {
        // return true if the person is from manchester
        public bool IsFromManchester(Person person)
        {
            if (person != null && person.getCity() == "Manchester")
            { return true; }
            else { return false; }
        }
        
        public bool CanWatchFilm(Person person, int ageLimit)
        {
            if (person != null && person.getAge() >= ageLimit)
            { return true; }
            else { return false; }
        }
    }
    public class Person
    {
        private string firstName = "";
        private string lastName = "";
        private string city = "";
        private int age = 0;

        public Person(string firstName, string lastName, string city, int age)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.city = city;
            this.age = age;
        }
        public string getFirstName()
        {
            return this.firstName;
        }
        public string getLastName()
        {
            return this.lastName;
        }
        public string getCity()
        {
            return this.city;
        }
        public int getAge()
        {
            return this.age;
        }
        public void setFirstName(string firstName)
        {
            this.firstName = firstName;
        }
        public void setLastName(string lastName)
        {
            this.lastName = lastName;
        }
        public void setCity(string city)
        {
            this.city = city;
        }
        public void setAge(int age)
        {
            this.age = age;
        }
    }
}
