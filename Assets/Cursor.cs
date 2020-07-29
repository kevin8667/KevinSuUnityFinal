using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cursor : MonoBehaviour
{
    public int currentTarget = 0;
    // Start is called before the first frame update
    void Start()
    {
        transform.position = CatchingTarget.targetList[0].transform.position + new Vector3(-80, 0, 0);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.UpArrow)) 
        {

            if (currentTarget < CatchingTarget.targetList.Length-1)
            {
                currentTarget += 1;
                transform.position = CatchingTarget.targetList[currentTarget].transform.position + new Vector3(-80, 0, 0);
            }
            else if (currentTarget == CatchingTarget.targetList.Length-1) 
            {
                currentTarget = 0;
                transform.position = CatchingTarget.targetList[currentTarget].transform.position + new Vector3(-80, 0, 0);
            }
            
        }
        if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            if (currentTarget != 0) 
            {
                currentTarget -= 1;
                transform.position = CatchingTarget.targetList[currentTarget].transform.position + new Vector3(-80, 0, 0);
            }
            else if (currentTarget == 0)
            {
                currentTarget = CatchingTarget.targetList.Length-1;
                transform.position = CatchingTarget.targetList[currentTarget].transform.position + new Vector3(-80, 0, 0);
            }

        }
    }

}
