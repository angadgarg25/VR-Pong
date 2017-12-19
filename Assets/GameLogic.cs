using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameLogic : MonoBehaviour {

    public static bool buckets = false;
    private void OnTriggerEnter(Collider other)
    {
        buckets = true;
        transform.parent.gameObject.SetActive(false);
        if (transform.parent.transform.parent.name == "CupSet (1)") {
            MainLogic.computer_points++;
        } else
        {
            MainLogic.player_points++;
        }
        Debug.Log(MainLogic.computer_points);
        Debug.Log(MainLogic.player_points);
    }
}
