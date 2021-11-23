using UnityEngine;

[CreateAssetMenu(fileName = "Generator", menuName = "ScriptableObjects/Generator")]
public class GeneratorScriptableObject : ScriptableObject
{
    public string Name;
    public int Price;
    public int Strength;
    public int Energy;
    public int Distance;
}
