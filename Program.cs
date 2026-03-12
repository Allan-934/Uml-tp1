namespace UML_tp1;

class Program
{
    static void Main(string[] args)
    {
        Director d1 = new Director();
        d1.SetFirstName("Christopher");
        d1.SetLastName("Nolan");
        d1.SetCountry("United States");
        d1.Display();
    }
}
