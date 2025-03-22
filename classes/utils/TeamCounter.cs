namespace simulador.utils;

public class CounterTeam(string name)
{
    public string Name { get; private set; } = name;
    public int Counter { get; private set; } = 0;

    public void AddOne()
    {
        Counter++;
    }

    public void Add(int amount)
    {
        Counter += amount;
    }
}
