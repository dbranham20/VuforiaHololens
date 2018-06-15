using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class buttonScript : MonoBehaviour {


	// Use this for initialization
	void Start ()
    {	
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void buttonAction()
    {
        var imageTargetStatus = GameObject.FindGameObjectWithTag("vuforiaUI").GetComponent<Text>();
        var connectionStatus = GameObject.FindGameObjectWithTag("connectionUI").GetComponent<Text>();
       // imageTargetStatus.color = Color.green;
       // imageTargetStatus.text = "Found";
        connectionStatus.color = Color.green;
        connectionStatus.text = "Connected";
    }

}
