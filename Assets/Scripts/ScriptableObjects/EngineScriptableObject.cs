using UnityEngine;

[CreateAssetMenu(fileName = "Engine", menuName = "ScriptableObjects/Engine")]
public class EngineScriptableObject : ScriptableObject
{
    public string Name;
    public int Price;
    public int Strength;
    public int BattlePowerConsumption;
    public int MovementPowerConsumption;
}
