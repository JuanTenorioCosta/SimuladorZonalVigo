namespace simulador.core;

using simulador.classes;
using simulador.utils;

public class Season : ICloneable
{
    public Team[] Teams { get; private set; }
    public Match[][] Matches { get; private set; }

    // MARK: Constructor
    public Season(bool isClone = false)
    {
        Teams = new Team[14];

        if (isClone)
        {
            Teams = new Team[14];
            Matches = new Match[26][];
        }
        // MARK: Teams
        Teams[0] = new("Redeiras");
        Teams[1] = new("Novobasket");
        Teams[2] = new("PBB");
        Teams[3] = new("Illas Cíes");
        Teams[4] = new("Caselas");
        Teams[5] = new("Nigrán");
        Teams[6] = new("Mar de Vigo");
        Teams[7] = new("Condado");
        Teams[8] = new("Puerto Vigo");
        Teams[9] = new("Apostol");
        Teams[10] = new("Mos");
        Teams[11] = new("CBA");
        Teams[12] = new("Seis do Nadal");
        Teams[13] = new("Rodaballo");

        Matches = new Match[26][];

        // MARK: Week 1
        Matches[0] = [
            new( Teams[7], Teams[13] ),
            new( Teams[9], Teams[0] ),
            new( Teams[11], Teams[10] ),
            new( Teams[12], Teams[8] ),
            new( Teams[4], Teams[3] ),
            new( Teams[5], Teams[6] ),
            new( Teams[1], Teams[2] )
        ];

        Matches[0][0].SetGamePlayed([44, 36]);
        Matches[0][1].SetGamePlayed([52, 79]);
        Matches[0][2].SetGamePlayed([50, 66]);
        Matches[0][3].SetGamePlayed([2, 0]);
        Matches[0][4].SetGamePlayed([46, 44]);
        Matches[0][5].SetGamePlayed([61, 38]);
        Matches[0][6].SetGamePlayed([57, 44]);

        // MARK: Week 2
        Matches[1] = [
            new( Teams[6], Teams[1] ),
            new( Teams[9], Teams[3] ),
            new( Teams[0], Teams[5] ),
            new( Teams[13], Teams[4] ),
            new( Teams[8], Teams[7] ),
            new( Teams[2], Teams[11] ),
            new( Teams[12], Teams[10] )
        ];

        Matches[1][0].SetGamePlayed([46, 50]);
        Matches[1][1].SetGamePlayed([48, 71]);
        Matches[1][2].SetGamePlayed([63, 57]);
        Matches[1][3].SetGamePlayed([45, 67]);
        Matches[1][4].SetGamePlayed([52, 58]);
        Matches[1][5].SetGamePlayed([39, 50]);
        Matches[1][6].SetGamePlayed([66, 72]);

        // MARK: Week 3
        Matches[2] = [
            new( Teams[7], Teams[10] ),
            new( Teams[5], Teams[3] ),
            new( Teams[6], Teams[0] ),
            new( Teams[12], Teams[2] ),
            new( Teams[4], Teams[8] ),
            new( Teams[9], Teams[13] ),
            new( Teams[1], Teams[11] )
        ];

        Matches[2][0].SetGamePlayed([61, 63]);
        Matches[2][1].SetGamePlayed([69, 58]);
        Matches[2][2].SetGamePlayed([48, 46]);
        Matches[2][3].SetGamePlayed([52, 69]);
        Matches[2][4].SetGamePlayed([46, 57]);
        Matches[2][5].SetGamePlayed([77, 48]);
        Matches[2][6].SetGamePlayed([53, 58]);

        // MARK: Week 4
        Matches[3] = [
            new( Teams[10], Teams[4] ),
            new( Teams[2], Teams[7] ),
            new( Teams[0], Teams[1] ),
            new( Teams[13], Teams[5] ),
            new( Teams[8], Teams[9] ),
            new( Teams[11], Teams[12] ),
            new( Teams[3], Teams[6] )
        ];

        Matches[3][0].SetGamePlayed([37, 40]);
        Matches[3][1].SetGamePlayed([54, 49]);
        Matches[3][2].SetGamePlayed([60, 51]);
        Matches[3][3].SetGamePlayed([42, 69]);
        Matches[3][4].SetGamePlayed([53, 28]);
        Matches[3][5].SetGamePlayed([43, 56]);
        Matches[3][6].SetGamePlayed([59, 54]);

        // MARK: Week 5
        Matches[4] = [
            new( Teams[4], Teams[2] ),
            new( Teams[1], Teams[12] ),
            new( Teams[9], Teams[10] ),
            new( Teams[5], Teams[8] ),
            new( Teams[6], Teams[13] ),
            new( Teams[7], Teams[11] ),
            new( Teams[0], Teams[3] )
        ];

        Matches[4][0].SetGamePlayed([66, 57]);
        Matches[4][1].SetGamePlayed([83, 38]);
        Matches[4][2].SetGamePlayed([85, 71]);
        Matches[4][3].SetGamePlayed([65, 51]);
        Matches[4][4].SetGamePlayed([55, 40]);
        Matches[4][5].SetGamePlayed([54, 48]);
        Matches[4][6].SetGamePlayed([58, 59]);

        // MARK: Week 6
        Matches[5] = [
            new( Teams[10], Teams[5] ),
            new( Teams[2], Teams[9] ),
            new( Teams[3], Teams[1] ),
            new( Teams[13], Teams[0] ),
            new( Teams[11], Teams[4] ),
            new( Teams[12], Teams[7] ),
            new( Teams[8], Teams[6] )
        ];

        Matches[5][0].SetGamePlayed([60, 55]);
        Matches[5][1].SetGamePlayed([57, 54]);
        Matches[5][2].SetGamePlayed([51, 46]);
        Matches[5][3].SetGamePlayed([24, 72]);
        Matches[5][4].SetGamePlayed([52, 44]);
        Matches[5][5].SetGamePlayed([45, 51]);
        Matches[5][6].SetGamePlayed([58, 56]);

        // MARK: Week 7
        Matches[6] = [
            new( Teams[9], Teams[11] ),
            new( Teams[5], Teams[2] ),
            new( Teams[6], Teams[10] ),
            new( Teams[3], Teams[13] ),
            new( Teams[1], Teams[7] ),
            new( Teams[4], Teams[12] ),
            new( Teams[0], Teams[8] )
        ];

        Matches[6][0].SetGamePlayed([57, 64]);
        Matches[6][1].SetGamePlayed([59, 55]);
        Matches[6][2].SetGamePlayed([55, 50]);
        Matches[6][3].SetGamePlayed([52, 29]);
        Matches[6][4].SetGamePlayed([48, 38]);
        Matches[6][5].SetGamePlayed([63, 50]);
        Matches[6][6].SetGamePlayed([39, 52]);

        // MARK: Week 8
        Matches[7] = [
            new( Teams[10], Teams[0] ),
            new( Teams[2], Teams[6] ),
            new( Teams[8], Teams[3] ),
            new( Teams[11], Teams[5] ),
            new( Teams[12], Teams[9] ),
            new( Teams[7], Teams[4] ),
            new( Teams[1], Teams[13] )
        ];

        Matches[7][0].SetGamePlayed([53, 73]);
        Matches[7][1].SetGamePlayed([61, 54]);
        Matches[7][2].SetGamePlayed([87, 71]);
        Matches[7][3].SetGamePlayed([58, 70]);
        Matches[7][4].SetGamePlayed([43, 59]);
        Matches[7][5].SetGamePlayed([55, 64]);
        Matches[7][6].SetGamePlayed([65, 42]);

        // MARK: Week 9
        Matches[8] = [
            new( Teams[1], Teams[4] ),
            new( Teams[9], Teams[7] ),
            new( Teams[5], Teams[12] ),
            new( Teams[6], Teams[11] ),
            new( Teams[0], Teams[2] ),
            new( Teams[3], Teams[10] ),
            new( Teams[13], Teams[8] )
        ];

        Matches[8][0].SetGamePlayed([68, 41]);
        Matches[8][1].SetGamePlayed([62, 55]);
        Matches[8][2].SetGamePlayed([85, 51]);
        Matches[8][3].SetGamePlayed([64, 41]);
        Matches[8][4].SetGamePlayed([56, 48]);
        Matches[8][5].SetGamePlayed([58, 49]);
        Matches[8][6].SetGamePlayed([40, 77]);

        // MARK: Week 10
        Matches[9] = [
            new( Teams[7], Teams[5] ),
            new( Teams[1], Teams[8] ),
            new( Teams[2], Teams[3] ),
            new( Teams[4], Teams[9] ),
            new( Teams[11], Teams[0] ),
            new( Teams[12], Teams[6] ),
            new( Teams[13], Teams[10] )
        ];

        Matches[9][0].SetGamePlayed([63, 71]);
        Matches[9][1].SetGamePlayed([81, 53]);
        Matches[9][2].SetGamePlayed([65, 43]);
        Matches[9][3].SetGamePlayed([55, 41]);
        Matches[9][4].SetGamePlayed([36, 59]);
        Matches[9][5].SetGamePlayed([56, 70]);
        Matches[9][6].SetGamePlayed([42, 52]);

        // MARK: Week 11
        Matches[10] = [
            new( Teams[3], Teams[11] ),
            new( Teams[8], Teams[10] ),
            new( Teams[1], Teams[9] ),
            new( Teams[5], Teams[4] ),
            new( Teams[6], Teams[7] ),
            new( Teams[0], Teams[12] ),
            new( Teams[13], Teams[2] )
        ];

        Matches[10][0].SetGamePlayed([63, 44]);
        Matches[10][1].SetGamePlayed([66, 57]);
        Matches[10][2].SetGamePlayed([63, 35]);
        Matches[10][3].SetGamePlayed([58, 64]);
        Matches[10][4].SetGamePlayed([62, 45]);
        Matches[10][5].SetGamePlayed([65, 51]);
        Matches[10][6].SetGamePlayed([35, 70]);

        // MARK: Week 12
        Matches[11] = [
            new( Teams[4], Teams[6] ),
            new( Teams[1], Teams[10] ),
            new( Teams[9], Teams[5] ),
            new( Teams[2], Teams[8] ),
            new( Teams[11], Teams[13] ),
            new( Teams[7], Teams[0] ),
            new( Teams[12], Teams[3] )
        ];

        Matches[11][0].SetGamePlayed([59, 53]);
        Matches[11][1].SetGamePlayed([62, 51]);
        Matches[11][2].SetGamePlayed([62, 70]);
        Matches[11][3].SetGamePlayed([66, 52]);
        Matches[11][4].SetGamePlayed([54, 26]);
        Matches[11][5].SetGamePlayed([61, 58]);
        Matches[11][6].SetGamePlayed([67, 83]);

        // MARK: Week 13
        Matches[12] = [
            new( Teams[5], Teams[1] ),
            new( Teams[6], Teams[9] ),
            new( Teams[3], Teams[7] ),
            new( Teams[10], Teams[2] ),
            new( Teams[0], Teams[4] ),
            new( Teams[13], Teams[12] ),
            new( Teams[8], Teams[11] )
        ];

        Matches[12][0].SetGamePlayed([45, 54]);
        Matches[12][1].SetGamePlayed([85, 44]);
        Matches[12][2].SetGamePlayed([63, 81]);
        Matches[12][3].SetGamePlayed([62, 55]);
        Matches[12][4].SetGamePlayed([73, 60]);
        Matches[12][5].SetGamePlayed([46, 72]);
        Matches[12][6].SetGamePlayed([66, 34]);

        // MARK: Week 14
        Matches[13] = [
            new( Teams[2], Teams[1] ),
            new( Teams[10], Teams[11] ),
            new( Teams[8], Teams[12] ),
            new( Teams[3], Teams[4] ),
            new( Teams[6], Teams[5] ),
            new( Teams[13], Teams[7] ),
            new( Teams[0], Teams[9] )
        ];

        Matches[13][0].SetGamePlayed([57, 61]);
        Matches[13][1].SetGamePlayed([56, 45]);
        Matches[13][2].SetGamePlayed([88, 58]);
        Matches[13][3].SetGamePlayed([80, 63]);
        Matches[13][4].SetGamePlayed([71, 58]);
        Matches[13][5].SetGamePlayed([51, 79]);
        Matches[13][6].SetGamePlayed([63, 55]);

        // MARK: Week 15
        Matches[14] = [
            new( Teams[10], Teams[12] ),
            new( Teams[5], Teams[0] ),
            new( Teams[1], Teams[6] ),
            new( Teams[11], Teams[2] ),
            new( Teams[4], Teams[13] ),
            new( Teams[7], Teams[8] ),
            new( Teams[3], Teams[9] )
        ];

        Matches[14][0].SetGamePlayed([66, 57]);
        //Matches[14][1].SetGamePlayed( [ 56, 45 ] ); Nigrán - Redeiras
        Matches[14][2].SetGamePlayed([48, 59]);
        Matches[14][3].SetGamePlayed([46, 75]);
        Matches[14][4].SetGamePlayed([64, 50]);
        Matches[14][5].SetGamePlayed([77, 75]);
        Matches[14][6].SetGamePlayed([63, 54]);

        // MARK: Week 16
        Matches[15] = [
            new( Teams[2], Teams[12] ),
            new( Teams[10], Teams[7] ),
            new( Teams[8], Teams[4] ),
            new( Teams[11], Teams[1] ),
            new( Teams[13], Teams[9] ),
            new( Teams[0], Teams[6] ),
            new( Teams[3], Teams[5] )
        ];

        Matches[15][0].SetGamePlayed([68, 55]);
        Matches[15][1].SetGamePlayed([47, 75]);
        Matches[15][2].SetGamePlayed([82, 77]);
        Matches[15][3].SetGamePlayed([45, 60]);
        Matches[15][4].SetGamePlayed([31, 49]);
        Matches[15][5].SetGamePlayed([73, 68]);
        Matches[15][6].SetGamePlayed([55, 63]);

        // MARK: Week 17
        Matches[16] = [
            new( Teams[5], Teams[13] ),
            new( Teams[9], Teams[8] ),
            new( Teams[1], Teams[0] ),
            new( Teams[4], Teams[10] ),
            new( Teams[7], Teams[2] ),
            new( Teams[12], Teams[11] ),
            new( Teams[6], Teams[3] )
        ];

        Matches[16][0].SetGamePlayed([75, 37]);
        Matches[16][1].SetGamePlayed([69, 63]);
        Matches[16][2].SetGamePlayed([66, 43]);
        Matches[16][3].SetGamePlayed([75, 70]);
        Matches[16][4].SetGamePlayed([64, 73]);
        Matches[16][5].SetGamePlayed([59, 68]);
        Matches[16][6].SetGamePlayed([55, 60]);

        // MARK: Week 18
        Matches[17] = [
            new( Teams[12], Teams[1] ),
            new( Teams[2], Teams[4] ),
            new( Teams[10], Teams[9] ),
            new( Teams[8], Teams[5] ),
            new( Teams[3], Teams[0] ),
            new( Teams[11], Teams[7] ),
            new( Teams[13], Teams[6] )
        ];

        Matches[17][0].SetGamePlayed([60, 64]);
        Matches[17][1].SetGamePlayed([71, 59]);
        Matches[17][2].SetGamePlayed([52, 53]);
        Matches[17][3].SetGamePlayed([63, 62]);
        Matches[17][4].SetGamePlayed([65, 75]);
        Matches[17][5].SetGamePlayed([61, 73]);
        Matches[17][6].SetGamePlayed([29, 84]);

        // MARK: Week 19
        Matches[18] = [
            new( Teams[5], Teams[10] ),
            new( Teams[9], Teams[2] ),
            new( Teams[1], Teams[3] ),
            new( Teams[0], Teams[13] ),
            new( Teams[6], Teams[8] ),
            new( Teams[4], Teams[11] ),
            new( Teams[7], Teams[12] )
        ];

        Matches[18][0].SetGamePlayed([70, 58]);
        Matches[18][1].SetGamePlayed([41, 55]);
        Matches[18][2].SetGamePlayed([58, 54]);
        Matches[18][3].SetGamePlayed([58, 37]);
        Matches[18][4].SetGamePlayed([60, 64]);
        Matches[18][5].SetGamePlayed([49, 57]);
        Matches[18][6].SetGamePlayed([76, 52]);

        // MARK: Week 20
        Matches[19] = [
            new( Teams[2], Teams[5] ),
            new( Teams[7], Teams[1] ),
            new( Teams[11], Teams[9] ),
            new( Teams[13], Teams[3] ),
            new( Teams[12], Teams[4] ),
            new( Teams[10], Teams[6] ),
            new( Teams[8], Teams[0] )
        ];

        Matches[19][0].SetGamePlayed([74, 57]);
        Matches[19][1].SetGamePlayed([67, 51]);
        Matches[19][2].SetGamePlayed([34, 48]);
        Matches[19][3].SetGamePlayed([49, 67]);
        Matches[19][4].SetGamePlayed([55, 66]);
        Matches[19][5].SetGamePlayed([54, 68]);
        // Matches[19][6].SetGamePlayed( [ 76, 52 ] ); Puerto Vigo - Redeiras

        // MARK: Week 21
        Matches[20] = [
            new( Teams[3], Teams[8] ),
            new( Teams[9], Teams[12] ),
            new( Teams[13], Teams[1] ),
            new( Teams[0], Teams[10] ),
            new( Teams[6], Teams[2] ),
            new( Teams[4], Teams[7] ),
            new( Teams[5], Teams[11] )
        ];

        Matches[20][0].SetGamePlayed([63, 54]);
        Matches[20][1].SetGamePlayed([70, 60]);
        Matches[20][2].SetGamePlayed([44, 79]);
        Matches[20][3].SetGamePlayed([51, 55]);
        Matches[20][4].SetGamePlayed([71, 62]);
        Matches[20][5].SetGamePlayed([62, 61]);
        Matches[20][6].SetGamePlayed([77, 65]);

        // MARK: Week 22
        Matches[21] = [
            new( Teams[2], Teams[0] ),
            new( Teams[10], Teams[3] ),
            new( Teams[8], Teams[13] ),
            new( Teams[4], Teams[1] ),
            new( Teams[7], Teams[9] ),
            new( Teams[12], Teams[5] ),
            new( Teams[11], Teams[6] )
        ];

        Matches[21][0].SetGamePlayed([63, 57]);
        Matches[21][1].SetGamePlayed([44, 69]);
        Matches[21][2].SetGamePlayed([83, 65]);
        Matches[21][3].SetGamePlayed([46, 48]);
        Matches[21][4].SetGamePlayed([46, 57]);
        Matches[21][5].SetGamePlayed([69, 70]);
        Matches[21][6].SetGamePlayed([55, 82]);

        // MARK: Week 23
        Matches[22] = [
            new( Teams[5], Teams[7] ),
            new( Teams[9], Teams[4] ),
            new( Teams[8], Teams[1] ),
            new( Teams[3], Teams[2] ),
            new( Teams[0], Teams[11] ),
            new( Teams[6], Teams[12] ),
            new( Teams[10], Teams[13] )
        ];

        Matches[22][0].SetGamePlayed( [ 69, 64 ] ); // Nigrán - Condado
        Matches[22][1].SetGamePlayed( [ 53, 62 ] ); // Apostol - Caselas
        Matches[22][2].SetGamePlayed( [ 86, 75 ] ); // Puerto - Novobasket
        Matches[22][3].SetGamePlayed( [ 68, 59 ] ); // Illas Cíes - PBB
        Matches[22][4].SetGamePlayed( [ 61, 50 ] ); // Redeiras - CBA
        Matches[22][5].SetGamePlayed( [ 92, 82 ] ); // Mar de Vigo - Seis do Nadal
        // Matches[22][6].SetGamePlayed( [ 55, 82 ] ); Mos - Rodaballo

        // MARK: Week 24
        Matches[23] = [
            new( Teams[9], Teams[1] ),
            new( Teams[4], Teams[5] ),
            new( Teams[7], Teams[6] ),
            new( Teams[12], Teams[0] ),
            new( Teams[2], Teams[13] ),
            new( Teams[11], Teams[3] ),
            new( Teams[10], Teams[8] )
        ];

        // Matches[23][0].SetGamePlayed( [ 63, 57 ] ); Apostol - Novobasket
        // Matches[23][1].SetGamePlayed( [ 44, 69 ] ); Caselas - Nigrán
        // Matches[23][2].SetGamePlayed( [ 83, 65 ] ); Condado - Mar de Vigo
        // Matches[23][3].SetGamePlayed( [ 46, 48 ] ); Seis - Redeiras
        // Matches[23][4].SetGamePlayed( [ 46, 57 ] ); PBB - Rodaballo
        // Matches[23][5].SetGamePlayed( [ 69, 70 ] ); CBA - Illas Cíes
        // Matches[23][6].SetGamePlayed( [ 55, 82 ] ); Mos - Puerto

        // MARK: Week 25
        Matches[24] = [
            new( Teams[3], Teams[12] ),
            new( Teams[6], Teams[4] ),
            new( Teams[5], Teams[9] ),
            new( Teams[10], Teams[1] ),
            new( Teams[8], Teams[2] ),
            new( Teams[13], Teams[11] ),
            new( Teams[0], Teams[7] )
        ];

        // Matches[24][0].SetGamePlayed( [ 63, 57 ] ); Illas Cíes - Seis
        // Matches[24][1].SetGamePlayed( [ 44, 69 ] ); Mar de Vigo - Caselas
        // Matches[24][2].SetGamePlayed( [ 83, 65 ] ); Nigrán - Apostol
        // Matches[24][3].SetGamePlayed( [ 46, 48 ] ); Mos - Novobasket
        // Matches[24][4].SetGamePlayed( [ 46, 57 ] ); Puerto - PBB
        // Matches[24][5].SetGamePlayed( [ 69, 70 ] ); Rodaballo - CBA
        // Matches[24][6].SetGamePlayed( [ 55, 82 ] ); Redeiras - Condado

        // MARK: Week 26
        Matches[25] = [
            new( Teams[9], Teams[6] ),
            new( Teams[4], Teams[0] ),
            new( Teams[7], Teams[3] ),
            new( Teams[12], Teams[13] ),
            new( Teams[2], Teams[10] ),
            new( Teams[1], Teams[5] ),
            new( Teams[11], Teams[8] )
        ];

        // Matches[25][0].SetGamePlayed( [ 63, 57 ] ); Apostol - Mar de Vigo
        // Matches[25][1].SetGamePlayed( [ 44, 69 ] ); Caselas - Redeiras
        // Matches[25][2].SetGamePlayed( [ 83, 65 ] ); Condado - Illas Cíes
        // Matches[25][3].SetGamePlayed( [ 46, 48 ] ); Seis - Rodaballo
        // Matches[25][4].SetGamePlayed( [ 46, 57 ] ); PBB - Mos
        // Matches[25][5].SetGamePlayed( [ 69, 70 ] ); Novobasket - Nigrán
        // Matches[25][6].SetGamePlayed( [ 55, 82 ] ); CBA - Puerto
    }


    // MARK: Clone
    public object Clone()
    {
        Team[] clonedTeams = [.. Teams.Select(team => (Team)team.Clone())];

        Season season = new(true)
        {
            Teams = clonedTeams,
            Matches = [.. Matches.Select(week => week.Select(match => CloneMatch(match, clonedTeams)).ToArray())]
        };

        return season;
    }

    private static Match CloneMatch(Match match, Team[] teams)
    {
        Team clonedHome = teams.First(team => team.Name == match.Home.Name);
        Team clonedAway = teams.First(team => team.Name == match.Away.Name);

        return match.Clone(clonedHome, clonedAway);
    }

    // MARK: Simulador
    public void Simulate()
    {
        int[] weeksWithPendingDays = [15, 20, 23, 24, 25, 26];

        foreach (int week in weeksWithPendingDays)
        {
            Match[] pendingMatches = GetPendingMatches(week);
            foreach (Match match in pendingMatches)
            {
                match.Simulate();
            }
        }
    }

    // MARK: Getters Matches
    public Match[] GetWeekMatches(int week)
    {
        if (week > 26 || week < 1)
        {
            throw new ArgumentException("Week must be between 1 and 26.");
        }

        return Matches[week - 1];
    }

    // MARK: Pending matches
    public Match[] GetPendingMatches()
    {
        return [.. Matches.SelectMany(week => week.Where(match => match.Score == null))];
    }

    public Match[] GetPendingMatches(int week)
    {
        return [.. Matches[week - 1].Where(match => match.Score == null)];
    }

    public Team[] GetAscended()
    {
        return [.. GetLadder().Take(2)];
    }

    // MARK: Direct matches
    public Match[] GetDirectMatches(Team[] teams)
    {
        return [.. Matches.SelectMany(week => week.Where(match => teams.Contains(match.Home) && teams.Contains(match.Away)))];
    }
    public Match[] GetDirectMatches(Team teamA, Team teamB)
    {
        return [.. Matches.SelectMany(week => week.Where(match => match.Home == teamA && match.Away == teamB || match.Home == teamB && match.Away == teamA))];
    }

    // MARK: Ladder
    public Team[] GetLadder()
    {
        TeamComparer[] orderedTeams = [.. Teams.Select(team => new TeamComparer( team, team.Wins ) ) ];
        return Desempate.ClasificarEquipos(orderedTeams, [..Matches.SelectMany( m => m )]);
    }
}
