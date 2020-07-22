using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ATBBar : MonoBehaviour
{
    public static Image ATBBarImage;
    /*static Color hpPhase1 = new Color(0.2269491f, 0.5660378f, 0.31497f);
    static Color hpPhase2 = new Color(0.9716981f, 0.6161706f, 0f);
    static Color hpPhase3 = new Color(0.7169812f, 0.1358856f, 0f);*/


    public static void SetATBBarValue(float value)
    {
        ATBBarImage.fillAmount = value;
        /*if (HealthBarImage.fillAmount < 0.2f)
        {
            SetHealthBarColor(hpPhase3);
        }
        else if (HealthBarImage.fillAmount < 0.5f)
        {
            SetHealthBarColor(hpPhase2);
        }
        else
        {
            SetHealthBarColor(hpPhase1);
        }*/
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
