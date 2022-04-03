using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using static HealthPlayer1;
using static HealthPlayer2;
using static Counter;

public class PlayerController : MonoBehaviour
{
    public float speed = 5f;
    public GameObject bullet;
    public bool player1;
    public bool player2;
    private AudioSource blaster;
    
    void Start()
    {
        blaster = this.GetComponentInChildren<AudioSource>();
        
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
                blaster.Play();
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
                blaster.Play();
            }

        }

        if (HealthPlayer1.health <= 0 || HealthPlayer2.health <= 0 || Counter.currentTime <= 0 ) {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        }

    }


    void OnTriggerEnter2D(Collider2D collision) {
        if (collision.gameObject.tag == "EnemyBullet" || collision.gameObject.tag == "Asteroid"
        || collision.gameObject.tag == "Enemy") {
            if (player1) {
                HealthPlayer1.Damage(20);
            } else {
                HealthPlayer2.Damage(20);
            }
            Destroy(collision.gameObject);
        }
    }
}
