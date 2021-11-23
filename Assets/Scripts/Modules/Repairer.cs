public class Repairer : Module
{
    private readonly int _consumption;
    private readonly int _seconds;
    private readonly int _repairStrength;

    public Repairer(int consumptionm, int seconds, int repairStrength, string name, int price, int strength) : base(name, price, strength)
    {
        _consumption = consumptionm;
        _seconds = seconds;
        _repairStrength = repairStrength;
    }
}
