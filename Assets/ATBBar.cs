using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ATBBar : MonoBehaviour
{
    public static Image ATBBarImage;



    public static void SetATBBarValue(float value)
    {
        ATBBarImage.fillAmount = value;

    }

    public static float GetATBBarValue()
    {
        return ATBBarImage.fillAmount;
    }


    public static void SetHealthBarColor(Color healthColor)
    {
        ATBBarImage.color = healthColor;
    }


    private void Start()
    {
        ATBBarImage = GetComponent<Image>();
        SetATBBarValue(0f);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
