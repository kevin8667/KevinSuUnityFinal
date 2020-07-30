using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEditor;
using UnityEngine;

public class MenuManeger : MonoBehaviour
{
    public GameObject menuLayer2;
    public GameObject basicMenu;
    public GameObject cursor;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        /*if (basicMenu.activeSelf && Input.GetButtonDown("Cancel") && !cursor.activeSelf) 
        {
            menuLayer2.SetActive(false);
        }*/
    }
}
