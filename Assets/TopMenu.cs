using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TopMenu : MonoBehaviour
{
    static public GameObject[] basicActions;
    // Start is called before the first frame update
    void Start()
    {
        if (basicActions == null)
        {
            basicActions = GameObject.FindGameObjectsWithTag("BasicActions");
            for (int i = 0; i < basicActions.Length; i++)
            {
                Debug.Log(basicActions[i].name);
            }
        }
    }

    // Update is called once per frame
    void Update()
    {

    }
}
