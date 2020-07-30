using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActionListener : MonoBehaviour
{
    //universal object to check if any character moving
    public bool inAction = false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape)) 
        {

            Application.Quit();
        }
    }
}
