using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FightArea : MonoBehaviour
{
    public GameObject enemySlider;
    // Start is called before the first frame update
    void Start()
    {
        enemySlider.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter(Collider collision){
            if(collision.gameObject.name == "Player"){
                enemySlider.SetActive(true);
        }
    }
}
