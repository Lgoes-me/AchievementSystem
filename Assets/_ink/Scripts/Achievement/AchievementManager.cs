using System.Collections.Generic;
using UnityEngine;
using ScriptableObjectArchitecture;

public class AchievementManager : MonoBehaviour, IGameEventListener<string>
{
    public StringGameEvent achievementEvent;
    public List<AchievementItemUI> achievements;

    private Dictionary<string, AchievementItemUI> _achievementsDict;

    public void OnEventRaised(string value)
    {
        if(_achievementsDict.TryGetValue(value, out AchievementItemUI achievement))
        {
            achievement.EnableAchievement();
        }
    }

    public void Awake()
    {
        _achievementsDict = new Dictionary<string, AchievementItemUI>();

        foreach(AchievementItemUI achievement in achievements)
        {
            _achievementsDict.Add(achievement.thisAchievement.key, achievement);
        }
    }
}
