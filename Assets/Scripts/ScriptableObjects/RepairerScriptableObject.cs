using UnityEngine;

[CreateAssetMenu(fileName = "Repairer", menuName = "ScriptableObjects/Repairer")]
public class RepairerScriptableObject : ScriptableObject
{
    public string Name;
    public int Price;
    public int Strength;
    public int Consumption;
    public int Seconds;
    public int RepairStrength;
}
