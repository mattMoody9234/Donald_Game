using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dialog_Enter : MonoBehaviour {

    //game manager
    public Inside_White_House_Game_Manager gameManager;
    //
    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    //dialoge encounter
    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.name == "Trump")
        {

            gameManager.enterDialogue();
        }
    }
}
