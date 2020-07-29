using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Items : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Status chaStatus = GameObject.Find("PlayerCha1").GetComponent<Status>();
        Status eneStatus = GameObject.Find("EnemyA").GetComponent<Status>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
