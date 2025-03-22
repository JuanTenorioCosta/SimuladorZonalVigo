using simulador.classes;

namespace simulador.utils;

public static class Desempate
{
    static readonly string NOMBRE_PUERTO = "Puerto Vigo";

    public static Team[] ClasificarEquipos( TeamComparer[] equiposClasificar, Match[] enfrentamientosDirectos )
    {
        List<Team> finalLadder = [];
        TeamComparer[] ordenarEquipos = [.. equiposClasificar.OrderByDescending( eq => eq.Puntos )];

        for (int i = 0; i < ordenarEquipos.Length; i++)
        {
            // Si es el último elemento no hay nada que comparar
            if (i == ordenarEquipos.Length - 1)
            {
                finalLadder.Add(ordenarEquipos[i].Team);
                break;
            }
            // Si no hay empate se añade al principio y se va al siguiente
            if (ordenarEquipos[i].Puntos != ordenarEquipos[i + 1].Puntos)
            {
                finalLadder.Add(ordenarEquipos[i].Team);
            }
            // Si hay empate se añaden todos los equipos empatados
            else
            {
                int acc = 2;
                List<TeamComparer> tiedTeams = [ordenarEquipos[i], ordenarEquipos[i + 1]];
                while (i + acc < ordenarEquipos.Length && ordenarEquipos[i].Puntos == ordenarEquipos[i + acc].Puntos)
                {
                    tiedTeams.Add(ordenarEquipos[i + acc]);
                    acc++;
                }

                string[] nombresEquiposEmpatados = [..tiedTeams.Select( t => t.Team.Name )];
                Match[] enfrentamientosDirectosEmpates = [..enfrentamientosDirectos.Where(
                    match => nombresEquiposEmpatados.Contains( match.Home.Name ) && nombresEquiposEmpatados.Contains( match.Away.Name )
                )];

                Team[] sortedTiedTeams = Desempatar([.. tiedTeams.Select( eq => eq.Team )], enfrentamientosDirectosEmpates, [], []);
                for (int j = 0; j < sortedTiedTeams.Length; j++)
                {
                    finalLadder.Add(sortedTiedTeams[j]);
                }
                i += acc - 1;
            }
        }

        return [.. finalLadder ];
    }

    /**
     * MARK: Desempates
     *
     * Criterios:
     *
     * 1) Si uno de los equipos es Puerto de Vigo gana el otro.
     * 2) Ganador del enfrentamiento directo.
     * 3) Diferencia de puntos en los enfrentamientos directos.
     ----------------------------------------------------------
     NO APLICO ESTAS REGLAS (MUY POCO PROBABLES) - RESOLUCIÓN ARBITRARIA
     * 4) El máximo anotador en uno de los partidos.
     * 5) Más puntos anotados en la competición.
     */
    public static Team[] Desempatar(Team[] equiposEmpatados, Match[] enfrentamientosDirectos, Team[] equiposPorDelante, Team[] equiposPorDetras)
    {
        // Casos base
        if (equiposEmpatados.Length == 0)
        {
            // Caso base - No hay equipos empatados
            return [equiposEmpatados[0], .. equiposPorDelante, .. equiposPorDetras];
        }
        if (equiposEmpatados.Length == 1)
        {
            // Caso base - Solo un equipo empatado
            return [.. equiposPorDelante, equiposEmpatados[0], .. equiposPorDetras];
        }

        // Criterio 1: Ganador directo, no es Puerto de Vigo (Sanción)
        if (Array.Exists( equiposEmpatados, eq => eq.Name == NOMBRE_PUERTO ))
        {
            Team puerto = equiposEmpatados.First( eq => eq.Name == NOMBRE_PUERTO );
            Match[] nuevosEnfrentamientosDirectos = [ ..enfrentamientosDirectos.Where( match => match.Home.Name != NOMBRE_PUERTO && match.Away.Name != NOMBRE_PUERTO ) ];
            return Desempatar([.. equiposEmpatados.Where(eq => eq.Name != NOMBRE_PUERTO )], nuevosEnfrentamientosDirectos, equiposPorDelante, [.. equiposPorDetras, equiposEmpatados.First( eq => eq.Name == NOMBRE_PUERTO )]);
        }

        // Criterio 2: Más victorias obtenidas en enfrentamientos directos
        TeamComparer[] puntosEquipos = [.. equiposEmpatados.Select(equipo => new TeamComparer(equipo))];

        foreach (Match match in enfrentamientosDirectos)
        {
            Team ganadorPartido = match.GetWinner();
            puntosEquipos.First(equipo => equipo.Team == ganadorPartido).Puntos++;
        }

        // Comprobar si están todos empatados, si lo están pasar al siguiente criterio.
        bool estanEmpatadosTodos = true;
        int i = 0;

        do{
            if( puntosEquipos[i].Puntos == puntosEquipos[i+1].Puntos )
            {
                i++;
            }
            else
            {
                estanEmpatadosTodos = false;
            }
        } while( estanEmpatadosTodos && i < puntosEquipos.Length - 1 );

        if( !estanEmpatadosTodos )
        {
            return [ ..equiposPorDelante, ..ClasificarEquipos( puntosEquipos, enfrentamientosDirectos ), ..equiposPorDetras ];
        }

        // Criterio 3: Por puntos en enfrentamientos directoss
        foreach( TeamComparer team in puntosEquipos )
        {
            team.Puntos = 0;
        }

        foreach (Match match in enfrentamientosDirectos)
        {
            Team equipoGanador = match.GetWinner();
            Team equipoPerdedor = match.GetLoser();
            int diferenciaPuntos = match.GetWinnerScore() - match.GetLoserScore();
            puntosEquipos.First(equipo => equipo.Team.Name == equipoGanador.Name).Puntos += diferenciaPuntos;
            puntosEquipos.First(equipo => equipo.Team.Name == equipoPerdedor.Name).Puntos -= diferenciaPuntos;
        }

        // Comprobar si están todos empatados, si lo están pasar al siguiente criterio.
        estanEmpatadosTodos = true;
        i = 0;

        do{
            if( puntosEquipos[i].Puntos == puntosEquipos[i+1].Puntos )
            {
                i++;
            }
            else
            {
                estanEmpatadosTodos = false;
            }
        } while( estanEmpatadosTodos && i < puntosEquipos.Length - 1 );

        if( !estanEmpatadosTodos )
        {
            return [ ..equiposPorDelante, ..ClasificarEquipos( puntosEquipos, enfrentamientosDirectos ), ..equiposPorDetras ];
        }

        // Desempatar por victorias en enfrentamientos directos
        return [ ..equiposPorDelante, ..equiposEmpatados, ..equiposPorDetras ];
    }

}
