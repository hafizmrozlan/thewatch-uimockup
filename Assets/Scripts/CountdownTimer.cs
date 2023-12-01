using System;
using TMPro;
using UnityEngine;

public class CountdownTimer : MonoBehaviour
{
    [SerializeField] private float timeRemainingInSeconds = 60152f;
    [SerializeField] private TextMeshProUGUI timerText;

    void Update()
    {
        if (timeRemainingInSeconds > 0)
        {
            timeRemainingInSeconds -= Time.deltaTime;
            TimeSpan time = TimeSpan.FromSeconds(timeRemainingInSeconds);
            timerText.text = time.ToString(@"hh\:mm\:ss");
        }
        else
        {
            timeRemainingInSeconds = 60152f;
        }
    }
}
