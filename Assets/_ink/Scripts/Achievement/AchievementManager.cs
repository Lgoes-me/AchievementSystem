using System.Collections.Generic;
using UnityEngine;
using ScriptableObjectArchitecture;

public class AchievementManager : MonoBehaviour, IGameEventListener<string>
{
    public StringGameEvent achievementEvent;
    public AchievementPopUp achievementPopUp;
    public List<AchievementItemUI> achievements;

    private Dictionary<string, AchievementItemUI> _achievementsDict;

    public void Awake()
    {
        achievementEvent.AddListener(this);

        _achievementsDict = new Dictionary<string, AchievementItemUI>();

        foreach (AchievementItemUI achievement in achievements)
        {
            _achievementsDict.Add(achievement.thisAchievement.key, achievement);
        }
    }

    public void OnEventRaised(string value)
    {
        if (_achievementsDict.TryGetValue(value, out AchievementItemUI achievement))
        {
            if (!achievement.isEnabled)
            {
                achievement.EnableAchievement();
                achievementPopUp.Init(value);
            }
        }
    }

    public void OnDestroy()
    {
        achievementEvent.RemoveListener(this);
    }
}
