public class Spaceship
{
    private int _strength;
    private �ommand�enter _�ommand�enter;

    public Spaceship(int strength, �ommand�enter �ommand�enter)
    {
        _strength = strength;
        _�ommand�enter = �ommand�enter;
        CalculateStrength();
    }

    private void CalculateStrength()
    {
        _strength = _�ommand�enter.GetStrength();
    }

    public int GetStrength()
    {
        return _strength;
    }
}
