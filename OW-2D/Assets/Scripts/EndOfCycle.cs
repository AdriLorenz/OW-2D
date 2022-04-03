using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndOfCycle : MonoBehaviour
{
    static public float currentTime = 0f;
    float startingTime = 0f;
    int valueChanged = 0;
    static public int cycleNumber;

    void Start()
    {
        cycleNumber = 0;
        currentTime = startingTime;
    }

    // Update is called once per frame
    void Update()
    {
        Timer();
        // Debug.Log((int)currentTime);
    }

    void Timer () {
        currentTime += 1 * Time.deltaTime;

        if(currentTime > 180) {
            cycleNumber++;
        }

        if ((int)currentTime != valueChanged) {
            valueChanged = (int)currentTime;
        }
    }
}
