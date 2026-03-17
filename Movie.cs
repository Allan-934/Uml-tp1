public class Movie 
{
    private string title = string.Empty;
    private int duree;
    private Director director;

    public string GetTitle()
    {
        return title;
    }
    public void SetTitle(string title)
    {
        this.title = title;
    }

    public int GetDuree()
    {
        return duree;
    }
    public void SetDuree(int duree) 
    {
        this.duree = duree;
    }

    public Director GetDirector()
    {
        return director;
    }
    public void SetDirector(Director director)
    {
        this.director = director;
    }

    public void Display()
    {
        Console.WriteLine($"Title: {GetTitle()}, Duration: {GetDuree()} minutes, Director: {GetDirector().GetFirstName()} {GetDirector().GetLastName()}");
    }

} 