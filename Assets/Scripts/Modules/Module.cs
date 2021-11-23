public abstract class Module
{
    protected readonly string _name;
    protected readonly int _price;
    protected readonly int _strength;

    protected Module(string name, int price, int strength)
    {
        _name = name;
        _price = price;
        _strength = strength;
    }

    public virtual int GetStrength()
    {
        return _strength;
    }
}
