using System.Collections.Generic;
using UnityEngine;
using ScriptableObjectArchitecture;

public class AchievementManager : MonoBehaviour, IGameEventListener<string>
{
    public StringGameEvent achievementEvent;
    public List<AchievementItemUI> achievements;

    public Dictionary<string, AchievementItemUI> dictionary;

    public void OnEventRaised(string value)
    {
        throw new System.NotImplementedException();
    }

    public void Awake()
    {
        
    }
}
