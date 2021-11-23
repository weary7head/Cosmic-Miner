public class Collector : Module
{
    private readonly int _consumption;
    private readonly int _minerals;

    public Collector(int consumption, int minerals, string name, int price, int strength)
        : base(name, price, strength)
    {
        _consumption = consumption;
        _minerals= minerals;
    }
}
