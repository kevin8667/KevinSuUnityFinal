using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyATB : MonoBehaviour
{
    public GameObject test1;
    [SerializeField] float basicATBSpeed = 10f;
    float finalATBSpeed;
    Status status;
    bool isWaiting;
    ActionListener actionListener;
    Attack attack;
    // Start is called before the first frame update
    void Start()
    {
        actionListener = GameObject.Find("ActionListener").GetComponent<ActionListener>();
        attack = gameObject.GetComponent<Attack>();
        status = test1.GetComponent<Status>();
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
    IEnumerator WaitTimer()
    {
        isWaiting = true;

        yield return new WaitForSeconds(finalATBSpeed);
        if (actionListener.inAction)
        {
            StartCoroutine(PauseTimer());
        }
        attack.ATK(status.STR, GameObject.Find("PlayerCha1"));

        isWaiting = false;
    }

    IEnumerator PauseTimer() 
    {
        yield return new WaitForSeconds(2);
        actionListener.inAction = false;
    }

}
