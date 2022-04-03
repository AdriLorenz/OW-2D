using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static Counter;

public class EnemyController : MonoBehaviour
{
    public GameObject bullet;
    
    void Start()
    {
        StartCoroutine(EnemyShootingDelay());
    }

    void OnTriggerEnter2D(Collider2D collision) {
        if (collision.gameObject.tag == "Bullet") {
            Debug.Log("si");
            Counter.currentTime += 3;
            Destroy(this.gameObject);
            Destroy(collision.gameObject);
        }
    }

    IEnumerator EnemyShootingDelay() {
        while (true) {
            Instantiate(bullet, transform.position, Quaternion.identity);
            yield return new WaitForSeconds (2f);
        }
        
        
    }
}