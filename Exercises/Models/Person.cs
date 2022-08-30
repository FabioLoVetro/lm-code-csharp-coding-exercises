using System;

public class Person
{
    /// <summary>
    /// Constructor <c>Person</c>
    /// <param name = firstName> the name of the person. </param>
    /// <param name = lastName> the surname of the person. </param>
    /// <param name = city> the city of the person. </param>
    /// <param name = age> the age of the person. </param>
    /// </summary>
    public Person(string firstName, string lastName, string city, int age)
    {
        this.firstName = firstName;
        this.lastName = lastName;
        this.city = city;
        this.age = age;
    }
    /// <summary>
    /// Method <c>firstName</c>
    /// getter and setter for firstName.
    /// <return> a string the name of the person. </return>
    /// </summary>
    public string firstName { get; set; }
    /// <summary>
    /// Method <c>lastName</c>
    /// getter and setter for lastName.
    /// <return> a string the surname of the person. </return>
    /// </summary>
    public string lastName { get; set; }
    /// <summary>
    /// Method <c>city</c>
    /// getter and setter for city.
    /// <return> a string the city of the person. </return>
    /// </summary>
    public string city { get; set; }
    /// <summary>
    /// Method <c>age</c>
    /// getter and setter for age.
    /// <return> an in the age of the person. </return>
    /// </summary>
    public int age { get; set; }
  
}
