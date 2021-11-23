using UnityEngine;

[CreateAssetMenu(fileName = "Battery", menuName = "ScriptableObjects/Battery")]
public class BatteryScriptableObject : ScriptableObject
{
    public string Name;
    public int Price;
    public int Strength;
    public int EnergyLimit;
    public int BatteryLevel;
}
