public class Playlist
{
    private string name = string.Empty; 
    private List<Movie> movies = new List<Movie>();
    

    public string GetName()
    {
        return name;
    }

    public void SetName(string name)
    {
        this.name = name;
    }

    public List<Movie> GetMovies()
    {
        return movies;
    }

    public void SetMovies(List<Movie> movies)
    {
        this.movies = movies;
    }

    public void AddMovie (Movie movie)
    {
        if (movies == null)
        {
            movies = new List<Movie>();
        }
        movies.Add(movie);
    }

    public void DisplayMovies ()
    {
        Console.WriteLine($"Nom de la playlist: {GetName()}");
        Console.WriteLine("Films dans la playlist:");
        foreach (Movie movie in GetMovies())
        {
            Console.WriteLine($"- {movie.GetTitle()} Réalisé par : {movie.GetDirector().GetFirstName()} {movie.GetDirector().GetLastName()}");
        }
    }
}