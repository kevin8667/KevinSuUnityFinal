using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DamgeView : MonoBehaviour
{
    public Text damageText;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        showDMG();
    }

    public void showDMG() 
    {
        if (Attack.attacked) 
        {
            StartCoroutine(ShowTimer());
        }
        
    }

    IEnumerator ShowTimer()
    {
        damageText.gameObject.SetActive(true);
        damageText.text = Attack.damage.ToString();
        yield return new WaitForSeconds(2);
        damageText.gameObject.SetActive(false);
        Attack.attacked = false;
    }
}
