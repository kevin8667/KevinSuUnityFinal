using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Status : MonoBehaviour
{
    public int STR;
    public int DEF;
    public int INT;
    public int WIS;
    public int DEX;
    public int HP;
    public int MP;
    [SerializeField] Text currentHP;
    [SerializeField] Text currentMP;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        currentHP.text = HP.ToString();
        currentMP.text = MP.ToString();
        
    }
}
