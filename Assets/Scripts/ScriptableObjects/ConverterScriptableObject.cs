using UnityEngine;

[CreateAssetMenu(fileName = "Converter", menuName = "ScriptableObjects/Converter")]
public class ConverterScriptableObject : ScriptableObject
{
    public string Name;
    public int Price;
    public int Strength;
    public int Energy;
    public int Minerals;
}
