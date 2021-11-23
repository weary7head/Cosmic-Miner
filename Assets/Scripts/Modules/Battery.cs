public class Battery : Module
{
    private readonly int _energyLimit;
    private int _batteryLevel;

    public Battery(string name, int price, int strength, int energyLimit, int batteryLevel)
        : base(name, price, strength)
    {
        _energyLimit = energyLimit;
        _batteryLevel = _batteryLevel > _energyLimit ? _energyLimit : batteryLevel;
    }
}
