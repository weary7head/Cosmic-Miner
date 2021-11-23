using UnityEngine;

[CreateAssetMenu(fileName = "Gun", menuName = "ScriptableObjects/Gun")]
public class GunScriptableObject : ScriptableObject
{
    public string Name;
    public int Price;
    public int Strength;
    public int Damage;
    public int Consumption;
}
