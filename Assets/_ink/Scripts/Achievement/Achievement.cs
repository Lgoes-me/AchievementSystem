using UnityEngine;

[CreateAssetMenu(fileName = "Achievement", menuName = "ScriptableObjects/Achievement", order = 1)]
public class Achievement : ScriptableObject
{
    public string key;
    public string description;
    public Sprite image;
}
