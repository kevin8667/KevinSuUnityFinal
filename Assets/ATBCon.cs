using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ATBCon : MonoBehaviour
{
    [SerializeField] float DEX = 15;
    [SerializeField] float basicATBSpeed = 20f;
    float finalATBSpeed;
    public Image aTBBar;
    public GameObject basicMenu;
    public Button defaultButton;

    // Start is called before the first frame update
    void Start()
    {
        finalATBSpeed = basicATBSpeed - DEX * 0.1f;
        if (finalATBSpeed < 8) 
        {
            finalATBSpeed = 8;
        }

    }

    // Update is called once per frame
    void Update()
    {
        ATBBar.SetATBBarValue(ATBBar.GetATBBarValue() + 1.0f/finalATBSpeed * Time.deltaTime);
        
        if (ATBBar.GetATBBarValue() == 1f) 
        {
            basicMenu.SetActive(true);
        }
    }
}
