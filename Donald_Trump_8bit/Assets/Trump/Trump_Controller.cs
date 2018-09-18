using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Trump_Controller : MonoBehaviour {
    //variable for controllability
    // using for cutscenes and whatnot
    bool isControllable;

    //Trump stuff
    public GameObject Trump;
    private Animator trumpAnim;
    private SpriteRenderer trumpSR;

  
	// Use this for initialization
	void Start () {
        isControllable = true;
        trumpAnim = Trump.GetComponent<Animator>();
        trumpSR = Trump.GetComponent<SpriteRenderer>();
	}
	
	// Update is called once per frame
	void Update () {

        //movement handling
        if (isControllable)
        {
            if(Input.GetAxis("Horizontal") < 0f)
            {
                trumpAnim.SetBool("Run", true);
                trumpSR.flipX = true;
                Trump.transform.Translate(Time.deltaTime * -10.0f, 0.0f, 0.0f);
            }
            else if (Input.GetAxis("Horizontal") > 0f)
            {
                trumpAnim.SetBool("Run", true);
                trumpSR.flipX = false;
                Trump.transform.Translate(Time.deltaTime * 10.0f, 0.0f, 0.0f);
            }
            else
            {
                trumpAnim.SetBool("Run", false);
            }

        }
	}
}
