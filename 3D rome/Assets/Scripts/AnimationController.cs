using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimationController : MonoBehaviour
{
    Animator anim;
    int theWalkID;
    int theAttackID;
    int theWalkBackID;
    // AudioSource audios;
    public AudioClip walk;
    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
        theWalkID =Animator.StringToHash("Walking");
        theAttackID =Animator.StringToHash("Attack");
        theWalkBackID =Animator.StringToHash("WalkingBack");
        // audios = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        bool isWalking = anim.GetBool("Walking");
        bool isWalkingBack = anim.GetBool("WalkingBack");
        bool isAttack = anim.GetBool("Attack");
        bool pressedw = Input.GetKey("w");
        bool presseds = Input.GetKey("s");
        bool presseda = Input.GetKey("a");
        bool pressedd = Input.GetKey("d");
        bool pressedLeftMouse = Input.GetMouseButtonDown(0);

        if(!isWalking&&pressedw){
            anim.SetBool(theWalkID,true);
            // audios.clip = walk;
            // audios.Play();
        }
        if(isWalking&&!pressedw){
            anim.SetBool(theWalkID, false);
        }
        if(!pressedw&&pressedLeftMouse){
            anim.SetBool(theAttackID,true);
        }
        if(!pressedLeftMouse){
            anim.SetBool(theAttackID,false);
        }
        if(!isWalkingBack&&presseds){
            anim.SetBool(theWalkBackID,true);
        }
        if(isWalkingBack&&!presseds){
            anim.SetBool(theWalkBackID, false);
            // audios.clip = walk;
            // audios.Play();
        }
        if(!isWalkingBack&&pressedd){
            anim.SetBool(theWalkBackID,true);
        }
        if(isWalkingBack&&!pressedd){
            anim.SetBool(theWalkBackID, false);
            // audios.clip = walk;
            // audios.Play();
        }
        if(!isWalkingBack&&presseda){
            anim.SetBool(theWalkBackID,true);
        }
        if(isWalkingBack&&!presseda){
            anim.SetBool(theWalkBackID, false);
            // audios.clip = walk;
            // audios.Play();
        }
    }
}
