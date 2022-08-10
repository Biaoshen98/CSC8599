using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class WinGoMenu : MonoBehaviour
{
    public void GoMenu(){
        
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex-2);
        
    }
}
