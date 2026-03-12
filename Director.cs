public class Director
{
    private string firstName = string.Empty;
    private string lastName = string.Empty; 
    private string country = string.Empty; 

    public string GetFirstName()
    {
        return firstName;
    }
    public void SetFirstName(string firstName)
    {
        this.firstName = firstName;
    }

    public string GetLastName()
    {
        return lastName;
    }
    public void SetLastName(string lastName)
    {
        this.lastName = lastName;
    }       

    public string GetCountry()
    {
        return country;
    }       
    public void SetCountry(string country)
    {
        this.country = country;
    }

    public void Display()
    {
        Console.WriteLine($"First Name: {GetFirstName()}, Last Name: {GetLastName()}, Country: {GetCountry()}");
    }
}