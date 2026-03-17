namespace UML_tp1;

class Program
{
    static void Main(string[] args)
    {
        Director d1 = new Director();
        d1.SetFirstName("Christopher");
        d1.SetLastName("Nolan");
        // d1.Display();

        Director d2 = new Director(); 
        d2.SetFirstName("Steven");  
        d2.SetLastName("Spielberg");
        // d2.Display();

        Movie m1 = new Movie();
        m1.SetTitle("Inception");
        m1.SetDuree(148);
        m1.SetDirector(d1);
        // m1.Display();

        Movie m2 = new Movie();
        m2.SetTitle("Interstellar");
        m2.SetDuree(169);
        m2.SetDirector(d2);
        // m2.Display();

        Playlist p1 = new Playlist();  
        p1.SetName("Mes films préférés");
        p1.AddMovie(m1); 
        p1.AddMovie(m2);
        // p1.Display();

        Studio s1 = new Studio();
        s1.SetName("Warner Bros");
        s1.SetCity("Beverly Hills");


        Console.WriteLine($"Titre du film: {m1.GetTitle()}, Réalisateur: {m1.GetDirector().GetFirstName()} {m1.GetDirector().GetLastName()}");  

        Console.WriteLine($"Nom de la playlist: {p1.GetName()}");
        Console.WriteLine("Films dans la playlist:");
        foreach (Movie movie in p1.GetMovies())
        {
            Console.WriteLine($"- {movie.GetTitle()} Réalisé par : {movie.GetDirector().GetFirstName()} {movie.GetDirector().GetLastName()}");
        }



    }
}


