public class Storage : Module
{
    private readonly int _mineralsLimit;
    private int _minerals;

    public Storage(string name, int price, int strength, int minerals, int mineralsLimit) 
        : base(name, price, strength)
    {
        _mineralsLimit = minerals;
        _minerals = minerals > _mineralsLimit ? mineralsLimit : _minerals;
    }
}
