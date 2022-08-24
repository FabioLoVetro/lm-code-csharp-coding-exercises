using System;

public class Person
{
    ///<value>Property <c>firstName</c> the name of the person.</value>
    private string firstName = "";
    ///<value>Property <c>lastName</c> the surname of the person.</value>
    private string lastName = "";
    ///<value>Property <c>city</c> the city of the person.</value>
    private string city = "";
    ///<value>Property <c>age</c> the age of the person.</value>
    private int age = 0;

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
    /// Method <c>getFirstName</c>
    /// getter for firstName.
    /// <return> a string the name of the person. </return>
    /// </summary>
    public string getFirstName()
    {
        return this.firstName;
    }
    /// <summary>
    /// Method <c>getLastName</c>
    /// getter for lastName.
    /// <return> a string the surname of the person. </return>
    /// </summary>
    public string getLastName()
    {
        return this.lastName;
    }
    /// <summary>
    /// Method <c>getCity</c>
    /// getter for city.
    /// <return> a string the city of the person. </return>
    /// </summary>
    public string getCity()
    {
        return this.city;
    }
    /// <summary>
    /// Method <c>getAge</c>
    /// getter for age.
    /// <return> an in the age of the person. </return>
    /// </summary>
    public int getAge()
    {
        return this.age;
    }
    /// <summary>
    /// Method <c>setFirstName</c>
    /// setter for firstName.
    /// <param name = firstName> the name of the person. </param>
    /// </summary>
    public void setFirstName(string firstName)
    {
        this.firstName = firstName;
    }
    /// <summary>
    /// Method <c>setLastName</c>
    /// setter for lastName.
    /// <param name = lastName> the surname of the person. </param>
    /// </summary>
    public void setLastName(string lastName)
    {
        this.lastName = lastName;
    }
    /// <summary>
    /// Method <c>setCity</c>
    /// setter for city.
    /// <param name = city> the city of the person. </param>
    /// </summary>
    public void setCity(string city)
    {
        this.city = city;
    }
    /// <summary>
    /// Method <c>setAge</c>
    /// setter for setAge.
    /// <param name = age> the age of the person. </param>
    /// </summary>
    public void setAge(int age)
    {
        this.age = age;
    }
}
