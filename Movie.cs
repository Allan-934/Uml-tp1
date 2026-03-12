public class Movie
{
    private string Title = string.Empty;
    private int duration;
    private Director director  = new Director();

    public string GetTitle()
    {
        return Title;
    }
    public void SetTitle(string title)
    {
        this.Title = title;
    }

    public int GetDuration()
    {
        return duration;
    }

    public void SetDuration(int duration)
    {
        this.duration = duration;
    }

    public Director GetDirector()
    {
        return director;
    }
    public void SetDirector(Director director)
    {
        this.director = director;
    }
    
}