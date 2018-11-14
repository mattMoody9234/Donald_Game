using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DialogueBox : MonoBehaviour {
    //head in the chat box
    public Image presHead;

    //text in the chat box
    public Text textBox;



	// Use this for initialization
	void Start () {
        switch (StaticTracker.curHelpingPres)
        {
            case curPresident.JFK:
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
		
	}
}
