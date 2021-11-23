using UnityEngine;

[CreateAssetMenu(fileName = "Storage", menuName = "ScriptableObjects/Storage")]
public class StorageScriptableObject : ScriptableObject
{
    public string Name;
    public int Price;
    public int Strength;
    public int MineralsLimit;
    public int Minerals;
}
