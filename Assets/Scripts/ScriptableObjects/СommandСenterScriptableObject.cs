using UnityEngine;

[CreateAssetMenu(fileName = "СommandСenter", menuName = "ScriptableObjects/СommandСenter")]
public class СommandСenterScriptableObject : ScriptableObject
{
    public string Name;
    public int Price;
    public int Strength;
    public int BodiesLimit;
}
