using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HistoryBook : MonoBehaviour
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
            textBox1.text = "History Book:\nThis is a hospital.\nThe Roman army attached great importance to the health of its soldiers.Hospitals, baths, toilets and covered or uncovered sewers were a must for all largescale military camps. Hospitals are usually built to accommodate 5-10% of the entire unit, and even if there is no war, the hospital is often crowded. A report from the Vindolanda fortress in AD 90 states that of the 750 men of the 1st Auxiliary Brigade, 31 were hospitalized with injuries: 15 sick; 6 wounded; 10 with eye inflammation.";
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
