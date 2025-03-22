using simulador.classes;

namespace simulador.utils;

// MARK: Team Comparer
public class TeamComparer(Team team, int? puntos = null)
{
    public Team Team { get; set; } = team;
    public int Puntos { get; set; } = puntos != null ? (int) puntos : 0;
}
