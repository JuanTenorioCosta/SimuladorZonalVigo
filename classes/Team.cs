namespace simulador.classes;

public class Team(
  string name
) : ICloneable
{
    public string Name { get; private set; } = name;
    public int Wins { get; private set; } = 0;
    public int Losses { get; private set; } = 0;
    public double AveragePointsScored { get; private set; } = 0;
    public double AveragePointsAllowed { get; private set; } = 0;

    private int GetGamesPlayed()
    {
        return Wins + Losses;
    }

    public object Clone()
    {
        Team clone = new(Name)
        {
            Wins = Wins,
            Losses = Losses,
            AveragePointsScored = AveragePointsScored,
            AveragePointsAllowed = AveragePointsAllowed
        };

        return clone;
    }

    public void AddGame(int pointsScored, int pointsAllowed)
    {
        if (pointsAllowed == pointsScored)
        {
            throw new ArgumentException("Games can't end in a tie.");
        }

        int gamesPlayed = GetGamesPlayed();
        AveragePointsScored = ((AveragePointsScored * gamesPlayed) + pointsScored) / (gamesPlayed + 1);
        AveragePointsAllowed = ((AveragePointsAllowed * gamesPlayed) + pointsAllowed) / (gamesPlayed + 1);

        if (pointsAllowed > pointsScored)
        {
            Losses++;
        }
        else
        {
            Wins++;
        }
    }

    public int GetLadderPoints()
    {
        return Wins * 2;
    }

    public override string ToString()
    {
        return $"W: {Wins} L: {Losses} - {Name}";
    }

    public string CompleteDataToString()
    {
        return $"{Name}\nW:{Wins} L: {Losses}\nAverages: {AveragePointsScored} - {AveragePointsAllowed}\nNet rating: {AveragePointsScored - AveragePointsAllowed}";
    }
}
