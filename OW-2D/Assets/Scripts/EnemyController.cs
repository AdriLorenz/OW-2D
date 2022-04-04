using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static Counter;

public class EnemyController : MonoBehaviour
{
    public GameObject bullet;
    private AudioSource explosion;
    public GameObject explosionEffect;
    
    void Start()
    {
        explosion = this.GetComponentInChildren<AudioSource>();
        StartCoroutine(EnemyShootingDelay());
    }

    void OnTriggerEnter2D(Collider2D collision) {
        if (collision.gameObject.tag == "Bullet") {
            Counter.currentTime += 3;
            Destroy(this.gameObject);
            GameObject explosion = Instantiate(explosionEffect, transform.position, Quaternion.identity) as GameObject;
            Destroy(explosion, 0.2f);
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
