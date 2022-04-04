using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static EndOfCycle;

public class TimberHearthWaveController : MonoBehaviour
{
    public GameObject enemyPrefab;
    public GameObject asteroidPrefab;
    private Vector2 screenBounds;
    private int counter;
    private float spawnDelay;

    private int previusCycle;

    void Start()
    {
        counter = 0;
        spawnDelay= 2.5f;
        previusCycle = EndOfCycle.cycleNumber;

        screenBounds = Camera.main.ScreenToWorldPoint(new Vector3(Screen.width, Screen.height, Camera.main.transform.position.z ));
    }

    // Update is called once per frame
    void Update()
    {
        if ((int)EndOfCycle.currentTime == 5 && counter == 0) {
            StartCoroutine (Wave1());
            counter++;
        }
        else {
        }
            
        if ((int)EndOfCycle.currentTime == 35 && counter == 1 ) {
            StartCoroutine (Wave2());
            counter++;
        }

        if ((int)EndOfCycle.currentTime / 20 == 2 || (int)EndOfCycle.currentTime / 20 == 3 || 
        (int)EndOfCycle.currentTime / 20 == 4 || (int)EndOfCycle.currentTime / 20 == 5 ) {
            spawnDelay -= 0.25f;
        }

        Debug.Log(spawnDelay);
    }

    IEnumerator Wave1() {
        while (true) {
            yield return new WaitForSeconds(spawnDelay);
            Enemie();
        }
    }

    IEnumerator Wave2() {
        while (true) {
            yield return new WaitForSeconds(spawnDelay);
            Asteroid();
        }
    }

    private void Enemie() {
        GameObject a = Instantiate (enemyPrefab) as GameObject;
        a.transform.position = new Vector2(Random.Range(-screenBounds.x, screenBounds.x), screenBounds.y );
    }

    private void Asteroid() {
        GameObject b = Instantiate (asteroidPrefab) as GameObject;
        b.transform.position = new Vector2(Random.Range(-screenBounds.x, screenBounds.x), screenBounds.y );
    }
}
