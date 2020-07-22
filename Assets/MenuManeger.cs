using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEditor;
using UnityEngine;

public class MenuManeger : MonoBehaviour
{
    public GameObject menuL1;
    public GameObject menuL2;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (!menuL2.activeSelf && Input.GetButtonDown("Cancel")) 
        {
            menuL1.SetActive(false);
        }
        if (menuL2.activeSelf && Input.GetButtonDown("Cancel")) 
        {
            menuL2.SetActive(false);
        }
    }
}
