using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;
using UnityEngine.UI;

public class DialogueBox : MonoBehaviour {

    public Inside_White_House_Game_Manager gameManager;
    //head in the chat box
    public Image presHead;

    //text in the chat box
    public Text textBox;

    private string dialogueLocation;
    
    private List<string> dialogue;

    private int lineNum;

    // Use this for initialization
    void Start () {
        lineNum = 1;
        
        switch (StaticTracker.curHelpingPres)
        {
            case curPresident.JFK:
                dialogueLocation = "Resources/Dialogue/KennedyDialogue";
                break;
            case curPresident.GeorgeWBush:
                break;
            case curPresident.BillClinton:
                break;
            default:
                break;
        }

        using (StreamReader theStream = File.OpenText(dialogueLocation))
        {
            string holder = "";
            //theStream.E
            while ((holder = theStream.ReadLine()) != null)
            {           
                       dialogue.Add(holder);                     
            }
        }
    }
	
	// Update is called once per frame
	void Update () {
		if(gameManager.getShowChatBubble())
        {
            string display = "";
            for (int letterNUM = 0; letterNUM < dialogue[lineNum].Length; letterNUM++)
            {
                display += "I";
                textBox.text = display;
            }
        }
	}
}
