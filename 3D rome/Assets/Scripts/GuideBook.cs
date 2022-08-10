using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GuideBook : MonoBehaviour
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
            textBox1.text = "Guide Book:\nYou can use WASD to move!\nPress left mouth to attack!\nPress ESC pause the game!";
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
                textBox4.text = "Press V to read!";
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