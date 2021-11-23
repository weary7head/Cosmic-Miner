using UnityEngine;

[CreateAssetMenu(fileName = "Collector", menuName = "ScriptableObjects/Collector")]
public class CollectorScriptableObject : ScriptableObject
{
    public string Name;
    public int Price;
    public int Strength;
    public int Consumption;
    public int Minerals;
}
