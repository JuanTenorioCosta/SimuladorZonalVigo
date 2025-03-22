namespace simulador.classes;

public class Match(Team home, Team away) : ICloneable
{
    public Team Home { get; private set; } = home;
    public Team Away { get; private set; } = away;
    private int[]? _score;
    public int[]? Score
    {
        get => _score;
        private set
        {
            if (value == null || value.Length != 2)
            {
                throw new ArgumentException("Score must be an array of two integers.");
            }
            if (value[0] == value[1])
            {
                throw new ArgumentException("Games can't end in a tie.");
            }
            Home.AddGame(value[0], value[1]);
            Away.AddGame(value[1], value[0]);
            _score = value;
        }
    }

    public object Clone()
    {
        if (Home.Clone() is not Team clonedHome || Away.Clone() is not Team clonedAway)
        {
            throw new InvalidOperationException("Cloning the team failed.");
        }
        Match clone = new(clonedHome, clonedAway);

        if (Score != null)
        {
            clone._score = [Score[0], Score[1]];
        }

        return clone;
    }

    public Match Clone(Team home, Team away)
    {
        Match clone = new(home, away);

        if (Score != null)
        {
            clone._score = [Score[0], Score[1]];
        }

        return clone;
    }

    public Team GetWinner()
    {
        if (Score == null)
        {
            throw new ArgumentException("Game not played yet.");
        }

        return Score[0] > Score[1] ? Home : Away;
    }

    public int GetWinnerScore()
    {
        if (Score == null)
        {
            throw new ArgumentException("Game not played yet.");
        }

        return Score[0] > Score[1] ? Score[0] : Score[1];
    }

    public int GetLoserScore()
    {
        if (Score == null)
        {
            throw new ArgumentException("Game not played yet.");
        }

        return Score[0] < Score[1] ? Score[0] : Score[1];
    }

    public Team GetLoser()
    {
        if (Score == null)
        {
            throw new ArgumentException("Game not played yet.");
        }

        return Score[0] < Score[1] ? Home : Away;
    }

    public int GetDiferencia()
    {
        if (Score == null)
        {
            throw new ArgumentException("Game not played yet.");
        }

        return Math.Abs(Score[0] - Score[1]);
    }

    public void SetGamePlayed(int[] score)
    {
        if (score.Length != 2)
        {
            throw new ArgumentException("Score must be an array of two integers.");
        }
        if (score[0] == score[1])
        {
            throw new ArgumentException("Games can't end in a tie.");
        }
        if (Score != null)
        {
            throw new ArgumentException("Game already played.");
        }

        Score = score;
    }

    public void Simulate(int plusMinus = 6)
    {
        if (Score != null)
        {
            throw new ArgumentException("Game already played.");
        }
        Random random = new();
        double averageHomeScore = (Home.AveragePointsScored + Away.AveragePointsAllowed) / 2;
        double averageAwayScore = (Away.AveragePointsScored + Home.AveragePointsAllowed) / 2;

        int homeScore = (int)Math.Round(random.Next(plusMinus * -1, plusMinus + 1) + averageHomeScore);
        int awayScore = (int)Math.Round(random.Next(plusMinus * -1, plusMinus) + averageAwayScore);

        while (homeScore == awayScore)
        {
            homeScore += random.Next(0, 11);
            awayScore += random.Next(0, 10);
        }

        Score = [homeScore, awayScore];
    }

    public override string ToString()
    {
        string score;
        if (Score == null)
        {
            score = "| DNP |";
        }
        else
        {
            score = $"{Score[0]} - {Score[1]}";
        }

        return $"{Home.Name} {score} {Away.Name}";
    }
}
