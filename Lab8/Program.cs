
public delegate void MatchEndedEventHandler(object source, EventArgs args);

public class FootballMatch
{
    public event MatchEndedEventHandler MatchEnded;

    public string HomeTeam { get; set; }
    public string AwayTeam { get; set; }
    public int HomeScore { get; set; }
    public int AwayScore { get; set; }
    public bool IsOver { get; private set; }

    public FootballMatch(string homeTeam, string awayTeam)
    {
        HomeTeam = homeTeam;
        AwayTeam = awayTeam;
        HomeScore = 0;
        AwayScore = 0;
        IsOver = false;
    }

    public void Goal(string team)
    {
        if (team == HomeTeam)
            HomeScore++;
        else if (team == AwayTeam)
            AwayScore++;
    }

    public void EndMatch()
    {
        IsOver = true;
        OnMatchEnded();
    }

    protected virtual void OnMatchEnded()
    {
        if (MatchEnded != null)
            MatchEnded(this, EventArgs.Empty);
    }
}

public class Spectator
{
    public string Name { get; set; }

    public Spectator(string name)
    {
        Name = name;
    }

    // "Слушатель" события
    public void OnMatchEnded(object source, EventArgs args)
    {
        Console.WriteLine($"{Name}: The match ended. I'm going home.");
    }
}

class Program
{
    static void Main(string[] args)
    {
        FootballMatch match = new FootballMatch("TeamA", "TeamB");
        Spectator spectator1 = new Spectator("Bob");
        Spectator spectator2 = new Spectator("Alice");

        match.MatchEnded += spectator1.OnMatchEnded;
        match.MatchEnded += spectator2.OnMatchEnded;

        match.Goal("TeamA");
        match.Goal("TeamB");
        match.Goal("TeamA");

        match.EndMatch();
    }
}
