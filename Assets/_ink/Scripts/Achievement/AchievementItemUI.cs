using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class AchievementItemUI : MonoBehaviour
{
    public Achievement thisAchievement;

    public bool isEnabled;
    public Image image;
    public TMP_Text textLabel;

    public void OnEnable()
    {
        if(isEnabled)
        {
            EnableAchievement();
        }
    }

    public void EnableAchievement()
    {
        isEnabled = true;

        image.gameObject.SetActive(true);
        image.sprite = thisAchievement.image;

        textLabel.gameObject.SetActive(true);
        textLabel.text = thisAchievement.key;
    }
}
