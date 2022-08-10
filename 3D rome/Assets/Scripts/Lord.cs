using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Lord : MonoBehaviour
{
     public GameObject dialogueBox;
    public Text textBox1;
    public Text textBox4;

    private bool playerNpc= false;
    

    // Start is called before the first frame update
    void Start()
    {
        dialogueBox.SetActive(false);
    }
    
    
    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.V)&&playerNpc == true){
            dialogueBox.SetActive(true);
            textBox1.text = "I am the lord of this city!\nI allow you to move around in the city!\nYou can challenge my warriors if you want!";
            textBox4.text = " ";
        }
        if(playerNpc != true){
            textBox1.text = " ";
            textBox4.text = " ";
        }
    }
    
    private void OnTriggerEnter(Collider collision){
            if(collision.gameObject.name == "Player"){
                textBox4.text = "Press V to chat!";
                playerNpc = true;
            }
    }


    private void OnTriggerExit(Collider collision){
            if(collision.gameObject.name == "Player"){
                dialogueBox.SetActive(false);
                textBox1.text = " ";
                textBox4.text = " ";
                playerNpc = false;
            }
    }

    private void OnTriggerStay(Collider collision){
            if(collision.gameObject.name == "Player"){
            }
    }
}
