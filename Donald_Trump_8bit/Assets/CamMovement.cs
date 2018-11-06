using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamMovement : MonoBehaviour {
    //shoudl be able to use this for the cam in most scenes

    //the cam position
    public Transform camPos;

   
    //game manager
    public Inside_White_House_Game_Manager gameManager;

    //variable for max and min x x component
    public float xMaxLeft;
    public float xMaxRight;

    // Use this for initialization
    void Start () {
        gameManager.donPos = gameManager.Trump.GetComponent<Transform>();

        Vector3 holdPos;
        holdPos.x = gameManager.donPos.position.x;
        holdPos.y = camPos.position.y;
        holdPos.z = camPos.position.z;
        camPos.position = holdPos;
        
    }
	
	// Update is called once per frame
	void Update () {
        //go ahead and stop that boi from crossing the line

        if (gameManager.donPos.position.x <= xMaxLeft )
        {
            Vector3 holdPos;
            holdPos.x = xMaxLeft;
            holdPos.y = camPos.position.y;
            holdPos.z = camPos.position.z;
            camPos.position =  holdPos;
        }
        else if(gameManager.donPos.position.x >= xMaxRight)
        {
            Vector3 holdPos;
            holdPos.x = xMaxRight;
            holdPos.y = camPos.position.y;
            holdPos.z = camPos.position.z;
            camPos.position = holdPos;
        }
        else
        {
            Vector3 holdPos;
            holdPos.x = gameManager.donPos.position.x;
            holdPos.y = camPos.position.y;
            holdPos.z = camPos.position.z;
            camPos.position = holdPos;
        }

    }
}
