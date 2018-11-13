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
    private bool isInDialogue ;
    //displaying chat bubble
    private bool showChatBubble;
    public CamMovement gameCam;

    public SpriteRenderer talkingPres;

    public SpriteRenderer chatBubble;


    // Use this for initialization
    void Start () {
        turnOffTrump = Trump.GetComponent<Trump_Controller>();
        donPos = Trump.GetComponent<Transform>();
        isInDialogue = false;

        showChatBubble = false;
        switch (StaticTracker.curHelpingPres)
        {
            case curPresident.JFK:
                talkingPres.sprite = Resources.Load("Past Presidents/Kennedy/8bit Kennedy 2", typeof(Sprite)) as Sprite;
                break;
            case curPresident.GeorgeWBush:
                talkingPres.sprite = Resources.Load("Past Presidents/Bush/8bit Bush", typeof(Sprite)) as Sprite;
                break;
            case curPresident.BillClinton:
                talkingPres.sprite = Resources.Load("Past Presidents/Clinton/8bit Clinton", typeof(Sprite)) as Sprite;
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
        if (showChatBubble)
        {
            chatBubble.enabled = true;
            Debug.Log("update loop with chat bubble true");
        }
        else
        {
            
            chatBubble.enabled = false;
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
    public bool getShowChatBubble()
    {
        return showChatBubble;
    }
    public void setShowChatBubble(bool doOrDont)
    {
        showChatBubble = doOrDont;
        Debug.Log("Set chat bubble to show up");
    }
    public void enterDialogue()
    {
        isInDialogue = true;
        gameCam.setLerpTime(true);
        //gameCam.lerpCam(gameCam.transform.position.x, gameCam.xMaxRight, 0.0001f);
    }
}
