namespace UML_tp1;

class Program
{
    static void Main(string[] args)
    {
        Director d1 = new Director();
        d1.SetFirstName("Christopher");
        d1.SetLastName("Nolan");

        Movie m1 = new Movie();
        m1.SetTitle("Inception");
        m1.SetDuration(148);
        m1.SetDirector(d1);
        Console.WriteLine($"Movie Title: {m1.GetTitle()}, Réalisateur: {m1.GetDirector()}");  // pas bon le nom du réalisateur s'affiche pas 
    }
}
