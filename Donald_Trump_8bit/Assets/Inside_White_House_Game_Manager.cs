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

    public SpriteRenderer talkingPres;

    // Use this for initialization
    void Start () {
        turnOffTrump = Trump.GetComponent<Trump_Controller>();
        donPos = Trump.GetComponent<Transform>();
        isInDialogue = false;


        switch (StaticTracker.curHelpingPres)
        {
            case curPresident.JFK:
                talkingPres.sprite = Resources.Load("Past Presidents/Kennedy/8bit Kennedy 2", typeof(Sprite)) as Sprite;
                Debug.Log("Made it in the JFK");
                break;
            case curPresident.GeorgeWBush:
                break;
            case curPresident.BillClinton:
                break;
            default:
                break;
        }

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
