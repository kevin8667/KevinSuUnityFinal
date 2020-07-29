using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Attack : MonoBehaviour
{
    ActionListener actionListener;
    CatchingTarget catchingTarget;
    // Start is called before the first frame update
    void Start()
    {
        actionListener = GameObject.Find("ActionListener").GetComponent<ActionListener>();
        catchingTarget = GameObject.Find("CatchingTarget").GetComponent<CatchingTarget>();
    }

    // Update is called once per frame
    void Update()
    {
 
    }

    public void ATK(int attackerSTR, GameObject target) 
    {
        actionListener.inAction = true;
        int targetDEF = target.GetComponent<Status>().DEF;
        float damage = (5 + (attackerSTR - targetDEF)) * UnityEngine.Random.Range(0.8f, 1.2f);
        if (damage <= 0) 
        {
            damage = 1;
        }
        Math.Round(damage);
        target.GetComponent<Status>().HP -= (int)damage;
        

    }
}
