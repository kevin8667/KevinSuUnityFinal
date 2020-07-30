using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyATB : MonoBehaviour
{
    public GameObject character;
    [SerializeField] float basicATBSpeed = 10f;
    float finalATBSpeed;
    Status status;
    bool isWaiting;
    ActionListener actionListener;
    // Start is called before the first frame update
    void Start()
    {
        actionListener = GameObject.Find("ActionListener").GetComponent<ActionListener>();
        status = character.GetComponent<Status>();
        finalATBSpeed = basicATBSpeed - status.DEX * 0.1f;
        if (finalATBSpeed < 4)
        {
            finalATBSpeed = 4;
        }

    }

    // Update is called once per frame
    void Update()
    {
        if (!isWaiting) 
        {
            StartCoroutine(WaitTimer());
        }
       
    }
    // ATB time without gauge
    IEnumerator WaitTimer()
    {
        isWaiting = true;

        yield return new WaitForSeconds(finalATBSpeed);
        if (actionListener.inAction)
        {
            StartCoroutine(PauseTimer());
        }
        Attack.ATK(status.STR, GameObject.Find("PlayerCha1"));

        isWaiting = false;
    }

    //if other character in actions
    IEnumerator PauseTimer() 
    {
        yield return new WaitForSeconds(2);
        actionListener.inAction = false;
    }

}
