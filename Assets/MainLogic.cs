using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainLogic : MonoBehaviour {

    public static int player_points;
    public static int computer_points;

    float force = 480f;
    float move_speed = 10f;

    public GameObject ball;

    enum Turn { PLAYER, COMPUTER };
    Turn turn;

	// Use this for initialization
	void Start () {
        turn = Turn.PLAYER;
	}
	
	// Update is called once per frame
	void Update () {
		if (ball.transform.position.y < 0 || GameLogic.buckets == true)
        {
            GameLogic.buckets = false;
            ball.GetComponent<Rigidbody>().velocity = Vector3.zero;
            ball.GetComponent<Rigidbody>().angularVelocity = Vector3.zero;
            if (turn == Turn.COMPUTER) {
                turn = Turn.PLAYER;
                ball.transform.position = new Vector3(-2.0985f, 1.213f, -6.7755f); //new Vector3(-2.0985f, 1.213f, -5f);
            } else
            {
                turn = Turn.COMPUTER;
                // do computer throw
                ball.transform.position = new Vector3(-4.534f, .924f, -7.0135f);

                ball.GetComponent<Rigidbody>().AddForce(new Vector3(.5f + Random.Range(-0.04f, 0.04f), .8f + Random.Range(-0.04f, 0.04f), 0f) * force);

            }
        }

        if (player_points == 10) {
            // Go to menu / win screen
            SceneManager.LoadScene(3);
        } else if (computer_points == 10)
        {
            // Go to menu / lose screen
            SceneManager.LoadScene(2);
        }
	}
}
