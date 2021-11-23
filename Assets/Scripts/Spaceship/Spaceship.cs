public class Spaceship
{
    private int _strength;
    private ÑommandÑenter _ñommandÑenter;

    public Spaceship(int strength, ÑommandÑenter ñommandÑenter)
    {
        _strength = strength;
        _ñommandÑenter = ñommandÑenter;
        CalculateStrength();
    }

    private void CalculateStrength()
    {
        _strength = _ñommandÑenter.GetStrength();
    }

    public int GetStrength()
    {
        return _strength;
    }
}
