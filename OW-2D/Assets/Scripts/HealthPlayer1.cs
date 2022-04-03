using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class HealthPlayer1 : MonoBehaviour
{
    public Image[] healthPoints;

    public static float health, maxHealth = 100;
    float lerpSpeed;

    private void Start()
    {
        health = maxHealth;
    }

    private void Update()
    {
        if (health > maxHealth) health= maxHealth;
        if (health < 0) health = 0;
        lerpSpeed = 3f * Time.deltaTime;
        HealthBarFiller();
    }

    void HealthBarFiller()
    {
        for (int i = 0; i < healthPoints.Length; i++)
        {
            healthPoints[i].enabled = !DisplayHealthPoint(health, i);
        }
    }

    bool DisplayHealthPoint(float _health, int pointNumber)
    {
        return ((pointNumber * 10) >= _health);
    }

    public static void Damage(float damagePoints)
    {
        if(health>0) health -= damagePoints;

    }

    public void Heal(float healingPoints)
    {
        if (health < maxHealth) health += healingPoints;
    }
}
