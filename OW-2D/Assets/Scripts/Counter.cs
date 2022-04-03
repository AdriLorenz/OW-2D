using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Counter : MonoBehaviour
{
    static public float currentTime = 0f;
    float startingTime = 20f;
    int valueChanged = 0;

    [SerializeField] TMP_Text countdownText;

    void Start()
    {
        currentTime = startingTime;
    }

    // Update is called once per frame
    void Update()
    {
        Countdown();
    }

    void Countdown () {
        currentTime -= 1 * Time.deltaTime;
        countdownText.text = currentTime.ToString("0");

        if ((int)currentTime != valueChanged) {
            valueChanged = (int)currentTime;
        }
    }
}
