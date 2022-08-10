using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter(Collider collision){
        if(collision.gameObject.tag == "Enemy"){
            Debug.Log("1");
        }
    }
        void OnTriggerExit(Collider collision){
        if(collision.gameObject.tag == "Enemy"){
            Debug.Log("2");
        }
    }
        void OnTriggerStay(Collider collision){
        if(collision.gameObject.tag == "Enemy"){
            Debug.Log("3");
        }
    }
}
