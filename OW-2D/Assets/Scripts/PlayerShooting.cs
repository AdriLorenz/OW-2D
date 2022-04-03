using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerShooting : MonoBehaviour
{
    public float bulletSpeed = 20f;
    private Rigidbody2D rb;
    // Start is called before the first frame update
    void Start()
    {
        GetComponent<Rigidbody2D>().velocity = new Vector2 (0, +bulletSpeed);
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
