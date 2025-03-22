using simulador.core;
using simulador.classes;
using simulador.utils;
using System.Collections.Concurrent;

Season season = new();

ConcurrentBag<CounterTeam[]> results = [];

void SimulateSeason(object? limit)
{
    if (limit is not int)
    {
        return;
    }

    // MARK: Teams
    CounterTeam[] counters =
    [
      new( "Redeiras" ),
        new( "Novobasket" ),
        new( "PBB" ),
        new( "Illas Cíes" ),
        new( "Caselas" ),
        new( "Nigrán" ),
        new( "Mar de Vigo" ),
        new( "Condado" ),
        new( "Puerto Vigo" ),
        new( "Apostol" ),
        new( "Mos" ),
        new( "CBA" ),
        new( "Seis do Nadal" ),
        new( "Rodaballo" ),
    ];

    Season? clone;

    int maxLimit = (int)limit;
    for (int i = 0; i < maxLimit; i++)
    {
        clone = season.Clone() as Season;
        if (clone == null)
        {
            break;
        }

        clone.Simulate();
        foreach (Team team in clone.GetAscended())
        {
            counters.First(counter => counter.Name == team.Name).AddOne();
        }
    }

    results.Add([.. counters.Where(counter => counter.Counter > 0)]);
}

int simulationsPerThread = 166667;
Thread[] threads = new Thread[6];

for (int i = 0; i < threads.Length; i++)
{
    threads[i] = new Thread(SimulateSeason);
    threads[i].Start(simulationsPerThread);
}

foreach (Thread thread in threads)
{
    thread.Join();
}

CounterTeam[] finalCounters =
[
    new("Redeiras"),
    new("Novobasket"),
    new("PBB"),
    new("Illas Cíes"),
    new("Caselas"),
    new("Nigrán"),
    new("Mar de Vigo"),
    new("Condado"),
    new("Puerto Vigo"),
    new("Apostol"),
    new("Mos"),
    new("CBA"),
    new("Seis do Nadal"),
    new("Rodaballo"),
];

foreach (CounterTeam[] counters in results)
{
    foreach (CounterTeam counter in counters)
    {
        finalCounters.First(fc => fc.Name == counter.Name).Add(counter.Counter);
    }
}

Console.WriteLine($"Después de {simulationsPerThread * threads.Length} simulaciones");
foreach (CounterTeam counter in finalCounters.Where(counter => counter.Counter > 0).OrderByDescending(counter => counter.Counter))
{
    decimal percentage = (decimal)counter.Counter * 100 / (simulationsPerThread * threads.Length);
    Console.WriteLine($"{counter.Name} clasifica el {percentage:0.00}% de las veces");
}
