using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Trump_Controller : MonoBehaviour
{
    //variable for controllability
    // using for cutscenes and whatnot
    public bool isControllable;
    bool hasJump;
    bool hasDoubleJump;

    //Trump stuff
    public GameObject Trump;
    private Animator trumpAnim;
    private SpriteRenderer trumpSR;
    private Transform trumpPos;
    private Rigidbody2D trumpRigid;

    //game manager
    public Inside_White_House_Game_Manager gameManager;

    //public Vector2 speed = new Vector2(150f, 10f);
    //Vector2 maxVelocity = new Vector2(60, 100 );
    // Use this for initialization
    void Start()
    {
        isControllable = true;
        hasJump = true;
        hasDoubleJump = true;
        trumpAnim = Trump.GetComponent<Animator>();
        trumpSR = Trump.GetComponent<SpriteRenderer>();
        trumpPos = Trump.GetComponent<Transform>();
        trumpRigid = Trump.GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (trumpPos.rotation.z != 0.0f)
        {
            Quaternion holdRot;
            holdRot.x = trumpPos.rotation.x;
            holdRot.y = trumpPos.rotation.y;
            holdRot.z = 0;
            holdRot.w =  trumpPos.rotation.w;
            trumpPos.rotation = holdRot;
            
        }
        //movement handling
        if (isControllable)
        {
            //float addForceX = 0.0f;
            //float addForceY = 0.0f;
            //float absVelocity = Mathf.Abs(trumpRigid.velocity.x);

            if (Input.GetAxis("Horizontal") < 0f)
            {
                trumpAnim.SetBool("Run", true);
                trumpSR.flipX = true;
                //trumpRigid.AddForce(new Vector2(-750000.0f, 0.0f));

                //Trump.transform.Translate(Time.deltaTime * -750.0f, 0.0f, 0.0f);
                //if (absVelocity < maxVelocity.x)
                //{
                //    addForceX = speed.x;
                //    trumpRigid.AddForce(new Vector2(addForceX, 0.0f));
                //}
                
                

            }
            else if (Input.GetAxis("Horizontal") > 0f)
            {
                trumpAnim.SetBool("Run", true);
                trumpSR.flipX = false;
                //trumpRigid.AddForce(new Vector2(7500000.0f, 0.0f));

                //Trump.transform.Translate(Time.deltaTime * 750.0f, 0.0f, 0.0f);
                //if (absVelocity < maxVelocity.x)
                //{
                //    addForceX = -speed.x;
                //    trumpRigid.AddForce(new Vector2(addForceX, 0.0f));
                //}
            }
            else
            {
                trumpAnim.SetBool("Run", false);
            }

            //jumping handling

            if (Input.GetAxis("Jump") > 0.0f)
            {
                if (hasJump)
                {
                    trumpAnim.SetTrigger("Jump");
                    trumpRigid.AddForce(Vector2.up * 1000.0f);
                    //Trump.transform.Translate(Time.deltaTime * 0.0f, 100.0f, 0.0f);           
                    hasJump = false;
                }
                else if (hasDoubleJump)
                {
                    trumpAnim.SetTrigger("Jump");
                    trumpRigid.AddForce(Vector2.up * 1000.0f);

                    //Trump.transform.Translate(Time.deltaTime * 0.0f, 100.0f, 0.0f);           
                    hasDoubleJump = false;
                }

            }

        }
    }

    public void turnOffTrump()
    {
        isControllable = false;
        trumpAnim.SetBool("Run", false);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.name == "Ground")
        {
            hasJump = true;
            hasDoubleJump = true;
        }
        //else
        //{
        //    Trump.GetComponent<Rigidbody2D>();
        //}
    }
}
