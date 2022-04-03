using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speed = 5f;
    public GameObject bullet;
    public bool player1;
    public bool player2;
    
    void Start()
    {
    }

    void Update()
    {
        if (player1) {

            if (Input.GetKey("d")) {
                transform.position = new Vector3(transform.position.x + speed * Time.deltaTime, transform.position.y, 0);
            }

            if (Input.GetKey("a")) {
                transform.position = new Vector3(transform.position.x - speed * Time.deltaTime, transform.position.y, 0);
            }

            if (Input.GetKey("w")) {
                transform.position = new Vector3(transform.position.x, transform.position.y + speed * Time.deltaTime, 0);
            }

            if (Input.GetKey("s")) {
                transform.position = new Vector3(transform.position.x, transform.position.y - speed * Time.deltaTime, 0);
            }

            if (Input.GetKeyDown("space")) {
                Instantiate(bullet, transform.position, Quaternion.identity);
            }

        }

        if (player2) {

            if (Input.GetKey("right")) {
                transform.position = new Vector3(transform.position.x + speed * Time.deltaTime, transform.position.y, 0);
            }

            if (Input.GetKey("left")) {
                transform.position = new Vector3(transform.position.x - speed * Time.deltaTime, transform.position.y, 0);
            }

            if (Input.GetKey("up")) {
                transform.position = new Vector3(transform.position.x, transform.position.y + speed * Time.deltaTime, 0);
            }

            if (Input.GetKey("down")) {
                transform.position = new Vector3(transform.position.x, transform.position.y - speed * Time.deltaTime, 0);
            }

            if (Input.GetKeyDown("right ctrl")) {
                Instantiate(bullet, transform.position, Quaternion.identity);
            }

        }

    }

        void OnTriggerEnter2D(Collider2D collision) {
        if (collision.gameObject.tag == "EnemyBullet" || collision.gameObject.tag == "Asteroid"
        || collision.gameObject.tag == "Enemy") {
            Destroy(this.gameObject);
            Destroy(collision.gameObject);
        }
    }
}
