using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Attack : MonoBehaviour
{
    static ActionListener actionListener;
    CatchingTarget catchingTarget;
    public static float damage;
    public static bool attacked;
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

    //calculate the gamage
    public static void ATK(int attackerSTR, GameObject target) 
    {
        actionListener.inAction = true;
        int targetDEF = target.GetComponent<Status>().DEF;
        damage = (5 + (attackerSTR - targetDEF)) * UnityEngine.Random.Range(0.8f, 1.2f);
        if (damage <= 0) 
        {
            damage = 1;
        }
        Math.Round(damage);
        target.GetComponent<Status>().HP -= (int)damage;
        attacked = true;

    }
}
