using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementLag : MonoBehaviour
{

    static int SIZE = 100;
    public GameObject person;
    Quaternion[] prev_rotations = new Quaternion[SIZE];
    Vector3[] prev_positions = new Vector3[SIZE];
    int current_index;
    int intoxication;

    Quaternion pr;
    Vector3 pp;
    bool play;

    // Use this for initialization
    void Start()
    {
        person = GameObject.Find("GameObject/Main Camera");
        current_index = 0;
        intoxication = 0;
    }

    //private void Update()
    //{
    //    if (Input.GetKeyDown(KeyCode.R))
    //    {
    //        person.transform.rotation = new Quaternion();
    //        person.transform.position = new Vector3();
    //        Debug.Log("recorded" + pr + " " + pp);
    //    }



    //}

    //private void LateUpdate()
    //{
    //    if (play)
    //    {
    //        person.transform.rotation = pr;
    //        person.transform.position = pp;
    //        Debug.Log("play" + person.transform.rotation + " " + person.transform.position);
    //    }
    //}


    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.R))
        {
            intoxication += 10;
            Debug.Log("Intoxication: " + intoxication);
        }
        if (Input.GetKeyDown(KeyCode.P))
        {
            intoxication -= 10;
            Debug.Log("Intoxication: " + intoxication);
        }
        Quaternion rotation = person.transform.rotation;
        Vector3 position = person.transform.position;

        if (intoxication != 0)
        {
            int prev_index = current_index - intoxication + SIZE;
            prev_index %= SIZE;
            person.transform.rotation = prev_rotations[prev_index];
            person.transform.position = prev_positions[prev_index];
        }

        prev_positions[current_index] = position;
        prev_rotations[current_index] = rotation;
        current_index++;
        current_index %= SIZE;

        if (current_index == 50)
        {
            Debug.Log(prev_rotations[50]);
        }

    }

    // Update is called once per frame
    //void FixedUpdate()
    //{
    //    if (Input.GetKeyDown(KeyCode.R))
    //    {
    //        intoxication += 10;
    //        Debug.Log("Intoxication: " + intoxication);
    //    }
    //    if (Input.GetKeyDown(KeyCode.P))
    //    {
    //        intoxication -= 10;
    //        Debug.Log("Intoxication: " + intoxication);
    //    }
    //    Quaternion rotation = person.transform.rotation;
    //    Vector3 position = person.transform.position;



    //    prev_positions[current_index] = position;
    //    prev_rotations[current_index] = rotation;
    //    current_index++;
    //    current_index %= SIZE;
    //}

    //void LateUpdate() {
    //    if (intoxication != 0)
    //    {
    //        int prev_index = current_index - intoxication + SIZE;
    //        prev_index %= SIZE;
    //        person.transform.rotation = prev_rotations[prev_index];
    //        person.transform.position = prev_positions[prev_index];
    //    }
    //}
}