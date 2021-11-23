public class Body : Module
{
    private Module[] _modules;

    public Body(int modulesLimit, string name, int price, int strength)
        : base(name, price, strength)
    {
        _modules = new Module[modulesLimit];
    }

    public void AddModule(Module module, int index)
    {
        _modules.SetValue(module, index);
    }

    public override int GetStrength()
    {
        int strength = 0;
        foreach (Module module in _modules)
        {
            strength += module.GetStrength();
        }
        return strength;
    }
}