using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HistoryBook2 : MonoBehaviour
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
            textBox1.text = "History Book:\nThe earliest Roman castles at Vindolanda were mainly made of wood. The remains are now buried in waterpoor, flooded soil to depths of up to 4 meters (13 feet). There are five wooden blockhouses, one after another (to be demolished). The first small fortresses were probably built by the first Tunguses around AD 85. A Batavia force of 1,000 mixed cavalries and infantry rebuilt the site in AD 95, expanding the wooden castle into a larger wooden castle than before. Later, in AD 100, the castle was restored and managed by troops under the command of Joseph Flavius Cerialis. However, when the Batavians left, they demolished the castle. This happened in AD 105. Later, the Tunguses used Vindolanda as a stronghold and built a larger wooden castle. They didn't move to Vercovicium (Roman fortress of Housesteads) until Hadrian's Wall was built around 122 AD.";
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
