public class Movie
{
    private string title = string.Empty;
    private int duree;

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
}