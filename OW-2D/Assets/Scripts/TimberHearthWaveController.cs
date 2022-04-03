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

    private int previusCycle;

    void Start()
    {
        counter = 0;
        previusCycle = EndOfCycle.cycleNumber;

        screenBounds = Camera.main.ScreenToWorldPoint(new Vector3(Screen.width, Screen.height, Camera.main.transform.position.z ));
        StartCoroutine (StartWaves());
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log(EndOfCycle.currentTime);
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
    }

    IEnumerator StartWaves() {
        Debug.Log("waiting");
        yield return new WaitForSeconds (10f);
    }

    IEnumerator Wave1() {
        while (true) {
            yield return new WaitForSeconds(2f);
            Enemie();
        }

    }

    IEnumerator Wave2() {
        while (true) {
            yield return new WaitForSeconds(2f);
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
