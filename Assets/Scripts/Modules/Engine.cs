public class Engine : Module
{
    private readonly int _battlePowerConsumption;
    private readonly int _movementPowerConsumption;

    public Engine(string name, int price, int strength, int battlePowerConsumption, int movementPowerConsumption)
        : base(name, price, strength)
    {
        _battlePowerConsumption = battlePowerConsumption;
        _movementPowerConsumption = movementPowerConsumption;
    }
}
