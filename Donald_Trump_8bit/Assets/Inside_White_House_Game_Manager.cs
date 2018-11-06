using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inside_White_House_Game_Manager : MonoBehaviour {

    private Trump_Controller turnOffTrump;
    //the donald
    public GameObject Trump;
    //the donald position
    private  Transform donPos;

    //colliding with the dialoge start
    private bool dialogueStart;

    // Use this for initialization
    void Start () {
        turnOffTrump = Trump.GetComponent<Trump_Controller>();
        donPos = Trump.GetComponent<Transform>();
        dialogueStart = false;
	}
	
	// Update is called once per frame
	void Update () {
        if (dialogueStart)
        {
            turnOffTrump.turnOffTrump();
        }
	}

    public Transform getDonPos()
    {
        return donPos;
    }
}
