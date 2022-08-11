using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Tab : MonoBehaviour
{
    public GameObject taskList;
    public Text firsttask;
    public Text secondtask;
    [SerializeField] private bool taskKey = true;
    // Start is called before the first frame update
    void Start()
    {
        taskList.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if(taskKey){
            if(Input.GetKeyDown(KeyCode.Tab)){
                taskList.SetActive(true);
                firsttask.text = "Earn 20 coins";
                secondtask.text = "Find 4 book";
                taskKey = false;
            }
        }
        else if(Input.GetKeyDown(KeyCode.Tab)){
            taskList.SetActive(false);
            taskKey = true;
        }
    }
}