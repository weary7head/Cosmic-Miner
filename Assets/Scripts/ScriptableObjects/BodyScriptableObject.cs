using UnityEngine;

[CreateAssetMenu(fileName = "Body", menuName = "ScriptableObjects/Body")]
public class BodyScriptableObject : ScriptableObject 
{
    public string Name;
    public int Price;
    public int Strength;
    public int ModulesLimit;
}