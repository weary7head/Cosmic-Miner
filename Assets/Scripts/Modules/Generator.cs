public class Generator : Module
{
    private readonly int _energy;
    private readonly int _distance;

    public Generator(int distance, int energy, string name, int price, int strength)
        : base(name, price, strength)
    {
        _energy = energy;
        _distance = distance;   
    }
}
