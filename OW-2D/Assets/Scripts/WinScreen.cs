using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;
using static HealthPlayer1;
using static HealthPlayer2;
using static Counter;

public class WinScreen : MonoBehaviour
{

    public bool player1Won;
    public bool player2Won;
    [SerializeField] TMP_Text player;
    // Start is called before the first frame update
    void Start()
    {

        if (HealthPlayer1.health <= 0) {
            player1Won = false;
            player2Won = true;
        }

        if (HealthPlayer2. health <= 0) {
            player2Won = false;
            player1Won = true;
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (player1Won == true) {
            player.text = "Player 1 won!";
        } else if (player2Won == true) {
            player.text = "Player 2 won!";
        } else {
            player.text = "Time is over";
        }
    }
}
