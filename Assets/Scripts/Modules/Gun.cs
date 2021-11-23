public class Gun : Module
{
    private readonly int _damage;
    private readonly int _consumption;
    public Gun(string name, int price, int strength, int damage, int consumption)
        : base(name, price, strength)
    {
        _damage = damage;
        _consumption = consumption;
    }
}
