using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyAI : MonoBehaviour
{
    public float speed = 5f;
    private Rigidbody2D rb;
    private Vector2 screenBounds;
    void Start()
    {
        rb = gameObject.GetComponent<Rigidbody2D>();
        rb.velocity = new Vector2(0, -speed);
        screenBounds = Camera.main.ScreenToWorldPoint(new Vector3(Screen.width, Screen.height, Camera.main.transform.position.z ));
        StartCoroutine(StopEnemy());
    }

    // Update is called once per frame
    void Update()
    {
    }

    IEnumerator StopEnemy() {
        yield return new WaitForSecondsRealtime(randomFloat());
        rb.constraints = RigidbodyConstraints2D.FreezeAll;
    }

    private float randomFloat() {
        return Random.Range(0.5f, 1.2f);
    }
}
