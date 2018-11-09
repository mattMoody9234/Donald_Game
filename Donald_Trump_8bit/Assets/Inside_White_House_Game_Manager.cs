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
    private bool isInDialogue;

    public CamMovement gameCam;

    // Use this for initialization
    void Start () {
        turnOffTrump = Trump.GetComponent<Trump_Controller>();
        donPos = Trump.GetComponent<Transform>();
        isInDialogue = false;
	}
	
	// Update is called once per frame
	void Update () {
        if (isInDialogue)
        {
            turnOffTrump.turnOffTrump();
        }
	}

    public Transform getDonPos()
    {
        return donPos;
    }

    public bool getIsInDialogue()
    {
        return isInDialogue;
    }

    public void enterDialogue()
    {
        isInDialogue = true;
        gameCam.setLerpTime(true);
        //gameCam.lerpCam(gameCam.transform.position.x, gameCam.xMaxRight, 0.0001f);
    }
}
