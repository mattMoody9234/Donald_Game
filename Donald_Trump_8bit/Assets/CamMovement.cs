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

    // Use this for initialization
    void Start()
    {
        

        

        ratio = 0.0001f;
        lerpTime = false;

 
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
            lerpCam(transform.position.x, xMaxRight);
            Debug.Log("Ayy we got the else");
        }
    }

    public void setLerpTime(bool toLerpOrNotToLerp)
    {
        Debug.Log("set lerp time to true");

        lerpTime = toLerpOrNotToLerp;
    }
    public void lerpCam(float startPos, float endPos)
    {
        //lerp formula (b-a) * r + a
        //a is destination / end
        //b is source / start
        Debug.Log("in lerp function");

        if (ratio <= 1.0f)
        {
            Debug.Log("big lerping");

            Vector3 holdPos;
            holdPos.x = (((endPos - startPos) * ratio) + startPos);
            holdPos.y = transform.position.y;
            holdPos.z = transform.position.z;
            transform.position = holdPos;

            ratio += 0.0001f;
        }
        else
        {
            lerpTime = false;
            ratio = 0.0001f;
            Debug.Log("lerp done");
             
        }

    }
}
