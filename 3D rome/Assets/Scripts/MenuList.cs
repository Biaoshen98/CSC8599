using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuList : MonoBehaviour
{
    public GameObject menuList;
    [SerializeField] private bool menuKey = true;
    [SerializeField] private AudioSource bgmSound;
    // Start is called before the first frame update
    void Start()
    {
        menuList.SetActive(false);
        Time.timeScale = (1);
    }

    // Update is called once per frame
    void Update()
    {
        if(menuKey){
            if(Input.GetKeyDown(KeyCode.Escape)){
                menuList.SetActive(true);
                menuKey = false;
                Time.timeScale = (0);
                bgmSound.Pause();
            }
        }
        else if(Input.GetKeyDown(KeyCode.Escape)){
            menuList.SetActive(false);
            menuKey = true;
            Time.timeScale = (1);
            bgmSound.Play();
        }

    }
}
