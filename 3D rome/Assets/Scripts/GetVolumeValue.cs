using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GetVolumeValue : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        DontDestroyOnLoad(gameObject);
    }

    // Update is called once per frame
    void Update()
    {
        UpdateGameObjectValue();
        GetGameObjectValue();
    }

    public void UpdateGameObjectValue(){
        Scene activeScene = SceneManager.GetActiveScene();
        if(activeScene.name == "MainMenu"){
            GameObject audioSlider = GameObject.FindGameObjectWithTag("UI").transform.GetChild(5).gameObject;
            PlayerPrefs.SetFloat("audioVolume", audioSlider.GetComponent<Slider>().value);
            print(PlayerPrefs.GetFloat("audioVolume"));
        }
    }

    public void GetGameObjectValue(){
        Scene activeScene = SceneManager.GetActiveScene();
        if(activeScene.name == "Rome"){
            GameObject romeAudio = GameObject.Find("Main Camera").transform.gameObject;
            romeAudio.GetComponent<AudioSource>().volume = PlayerPrefs.GetFloat("audioVolume");
        }
    }
}
