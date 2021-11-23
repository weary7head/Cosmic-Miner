public class Converter : Module
{
    private readonly int _energy;
    private readonly int _minerals;

    public Converter(int energy, int minerals, string name, int price, int strength)
        : base(name, price, strength)
    {
        _energy = energy;
        _minerals = minerals;
    }
}
