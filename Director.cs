public class Director
{
    private string firstName = string.Empty;
    private string lastName = string.Empty; 
    

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

    

    public void Display()
    {
        Console.WriteLine($"First Name: {GetFirstName()}, Last Name: {GetLastName()}");
    }
}