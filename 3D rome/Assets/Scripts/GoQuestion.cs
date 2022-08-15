using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GoQuestion : MonoBehaviour
{
    public void StartQuestion(){
        
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex+3);
        
    }
}
