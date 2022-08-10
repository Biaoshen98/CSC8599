using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Task : MonoBehaviour
{
    public GameObject dialogueBox;
    public GameObject textBox;

    private bool playerNpc= false;
    

    // Start is called before the first frame update
    void Start()
    {
        dialogueBox.SetActive(false);
        textBox.SetActive(false);
    }
    
    
    // Update is called once per frame
    void Update()
    {

    }
    
    private void OnTriggerEnter(Collider collision){
            if(collision.gameObject.name == "Player"){
                dialogueBox.SetActive(true);
                textBox.SetActive(true);
            }
    }


    private void OnTriggerExit(Collider collision){
            if(collision.gameObject.name == "Player"){
                dialogueBox.SetActive(false);
                textBox.SetActive(false);
            }
    }

    private void OnTriggerStay(Collider collision){
            if(collision.gameObject.name == "Player"){
            }
    }

    
}
