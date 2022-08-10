using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class PickUp : MonoBehaviour
{
    public int box=0;
    public Shop Getcoin;
    [SerializeField]private Text boxText;
    private AudioSource audioS;
    [SerializeField]private AudioClip Collect;
    // Start is called before the first frame update
    void Start()
    {
        Time.timeScale = (1);
        audioS = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
       if(Getcoin.coin >=20){
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex+1);
       }
    }

    void OnCollisionEnter(Collision collision){
        if(collision.gameObject.tag == "Box"){
            audioS.clip = Collect;
            audioS.Play();
            Destroy(collision.gameObject);
            box++;
            Debug.Log("Box: " + box);
        }
        boxText.text = "Box: " + box;
    }
}
