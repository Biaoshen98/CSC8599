using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sward : MonoBehaviour
{
     Animator anim;
     int theAttackEdID;
    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
        theAttackEdID =Animator.StringToHash("Death");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnTriggerEnter(Collider collision){
        if(collision.gameObject.name == "Sward"){
            Debug.Log("1");
            bool isAttackEd = anim.GetBool("Death");
            anim.SetBool(theAttackEdID,true);
            Destroy(gameObject,5f);
        }
    }
}
