using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Shop : MonoBehaviour
{
    public int coin= 0;
    public GameObject dialogueBox;
    public Text textBox1;
    public Text textBox4;
    public Text boxText;
    public Text coinText;
    private bool playerNpc= false;
    public PickUp GetBox;
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
            textBox1.text = "Hi,warrior\nYou can use 5 boxs of food to change 10 coin!\nPress E to change!";
            textBox4.text = " ";
        }
        if(Input.GetKeyDown(KeyCode.E)&&playerNpc == true){
            Debug.Log("coin");
            if(GetBox.box-5>=0){
                GetBox.box = GetBox.box -5;
                coin = coin + 10; 
                textBox1.text = "Success to change. Do u want to change more?";
                textBox4.text = " ";
            }
            else{
                textBox1.text = "Food not enough!!!";
            }
            boxText.text = "Number: " + GetBox.box;
            coinText.text = "Number: " + coin;
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
