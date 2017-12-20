using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class SelectOnInput : MonoBehaviour {

    public EventSystem eventSystem;
    public GameObject selectedObject;

    private bool buttonSelected;
    private bool triggerIsDown = false;

	// Use this for initialization
	void Start () {
        triggerIsDown = false;
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetAxisRaw("Vertical") != 0)
        {
            Debug.Log("merp");
            if (!triggerIsDown)
            {
                eventSystem.SetSelectedGameObject(selectedObject);
                buttonSelected = true;
                triggerIsDown = true;
            } else
            {
                // triggerIsDown = false;
            }
        }
	}

    private void OnDisable()
    {
        buttonSelected = false;
        triggerIsDown = false;
    }
}
