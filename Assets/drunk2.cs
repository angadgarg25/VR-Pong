using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.ImageEffects;

public class drunk2 : MonoBehaviour {

    // Use this for initialization
    //public GameObject camHudgins;
    //private MotionBlur mblur;
	void Start () {
        //mblur = camHudgins.GetComponent<MotionBlur>();
        //mblur.enabled = true;
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKeyDown(KeyCode.R)) {
            MotionBlur.blurAmount += 0.1f;
        }
    }
}
