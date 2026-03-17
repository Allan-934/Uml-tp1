namespace UML_tp1;

class Program
{
    static void Main(string[] args)
    {
        Director d1 = new Director();
        d1.SetFirstName("Christopher");
        d1.SetLastName("Nolan");
        d1.Display();

        Movie m1 = new Movie();
        m1.SetTitle("Inception");
        m1.SetDuree(148);
        m1.SetDirector(d1);
        m1.Display();
        Console.WriteLine($"Titre du film: {m1.GetTitle()}, Réalisateur: {m1.GetDirector().GetFirstName()} {m1.GetDirector().GetLastName()}");  
    }
}


