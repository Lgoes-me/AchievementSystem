using System.Collections;
using UnityEngine;
using TMPro;

public class AchievementPopUp : MonoBehaviour
{
    public TMP_Text textLabel;
    public float timer;

    public void Init(string value)
    {
        textLabel.text = value;
        gameObject.SetActive(true);

        StartCoroutine(ReturnToSleep());
    }
    
    private IEnumerator ReturnToSleep()
    {
        yield return new WaitForSeconds(timer);

        textLabel.text = "";
        gameObject.SetActive(false);
    }
}
