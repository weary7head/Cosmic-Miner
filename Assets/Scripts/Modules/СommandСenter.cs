public class СommandСenter : Module
{
    private Body[] _bodies;

    public СommandСenter(int _bodiesLimit,string name, int price, int strength)
        : base(name, price, strength)
    {
        _bodies = new Body[_bodiesLimit];
    }

    public void AddBody(Body body, int index)
    {
        _bodies.SetValue(body, index);
    }

    public void AddModule(Module module, int bodyIndex, int moduleIndex)
    {
        _bodies[bodyIndex].AddModule(module, moduleIndex);
    }

    public override int GetStrength()
    {
        int strength = 0;
        foreach (Body body in _bodies)
        {
            if (body != null)
            {
                strength += body.GetStrength();
            }
        }
        strength += _strength;
        return strength;
    }
}
