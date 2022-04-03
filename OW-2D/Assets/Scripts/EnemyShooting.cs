using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyShooting : MonoBehaviour
{
    public float bulletSpeed = 20f;
    void Start()
    {
        GetComponent<Rigidbody2D>().velocity = new Vector2 (0, -bulletSpeed);
        StartCoroutine(DeleteBullet());
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    IEnumerator DeleteBullet() {
        yield return new WaitForSeconds(1.5f);
        Destroy(this.gameObject);
    }
    
}
