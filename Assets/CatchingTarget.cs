using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CatchingTarget : MonoBehaviour
{
    public Button targetButton;
    public GameObject cursor;
    static public GameObject[] targetList;
    Cursor cursorS;
    // Start is called before the first frame update

    private void Awake()
    {
        if (targetList == null)
        {
            targetList = GameObject.FindGameObjectsWithTag("Enemy");
            for (int i = 0; i < targetList.Length; i++) 
            {
                Debug.Log(targetList[i].name);
            }
        }

        
    }

    // Update is called once per frame
    void Update()
    {
        if (cursor == null)
        {
            cursor = GameObject.FindGameObjectWithTag("Cursor");

        }
        cursorS = cursor.GetComponent<Cursor>();
        if (Input.GetButtonDown("Submit"))
        {
            Debug.Log(TargetSelect().name);


        }
        
    }

    public GameObject TargetSelect()
    {
       
        return targetList[cursorS.currentTarget];

    }


}
