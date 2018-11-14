using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamMovement : MonoBehaviour
{
    //shoudl be able to use this for the cam in most scenes

    //the cam position
   // public Transform camPos;


    //game manager
    public Inside_White_House_Game_Manager gameManager;

    //variable for max and min x x component
    public float xMaxLeft;
    public float xMaxRight;

    //use for lerping
    float ratio;
    bool lerpTime;
    float startingLerpPos;
    // Use this for initialization
    void Start()
    {
        

        

        ratio = 0.005f;
        lerpTime = false;
        startingLerpPos = 0.0f;
 
    }

    // Update is called once per frame
    void Update()
    {
        //go ahead and stop that boi from crossing the line
        if (!lerpTime && !gameManager.getIsInDialogue())
        {

            if (gameManager.getDonPos().position.x <= xMaxLeft)
            {
                Vector3 holdPos;
                holdPos.x = xMaxLeft;
                holdPos.y = transform.position.y;
                holdPos.z = transform.position.z;
                transform.position = holdPos;
            }
            else if (gameManager.getDonPos().position.x >= xMaxRight)
            {
                Vector3 holdPos;
                holdPos.x = xMaxRight;
                holdPos.y = transform.position.y;
                holdPos.z = transform.position.z;
                transform.position = holdPos;
            }
            else
            {
                Vector3 holdPos;
                holdPos.x = gameManager.getDonPos().position.x;
                holdPos.y = transform.position.y;
                holdPos.z = transform.position.z;
                transform.position = holdPos;
            }
        }
        else if(lerpTime)
        {
            if(startingLerpPos == 0.0f)
            {
                startingLerpPos = transform.position.x;
            }
            lerpCam(startingLerpPos, xMaxRight);

        }
    }

    public void setLerpTime(bool toLerpOrNotToLerp)
    {
        lerpTime = toLerpOrNotToLerp;
    }
    public void lerpCam(float startPos, float endPos)
    {
        //lerp formula (b-a) * r + a
        //a is destination / end
        //b is source / start

      

        if (ratio <= 1.0f)
        {

            Vector3 holdPos;
           holdPos.x = (((endPos - startPos) * ratio) + startPos);
           // holdPos.x = (((startPos - endPos) * ratio) + endPos);
            holdPos.y = transform.position.y;
            holdPos.z = transform.position.z;
            transform.position = holdPos;

            ratio += 0.005f;
        }
        else
        {
            lerpTime = false;
            ratio = 0.005f;
            gameManager.setShowChatBubble(true);
        Debug.Log("ended lerp");

        }

    }
}
