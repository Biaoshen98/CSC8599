using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Dialogue : MonoBehaviour
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
            textBox1.text = "Welcome!\nWelcome to Rome, my friend. This is Vindolanda!\nYou can challenge our Lord. Wish you enjoy!";
            textBox4.text = " ";
        }
        if(playerNpc != true){
            textBox1.text = " ";
            textBox4.text = " ";
        }
    }
    
    private void OnTriggerEnter(Collider collision){
            if(collision.gameObject.name == "Player"){
                playerNpc = true;
                textBox4.text = "Press V to chat!";
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
