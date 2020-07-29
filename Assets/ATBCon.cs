using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ATBCon : MonoBehaviour
{
    [SerializeField] float DEX = 15;
    [SerializeField] float basicATBSpeed = 10f;
    float finalATBSpeed;
    public Image aTBBar;
    public GameObject basicMenu;
    public Button defaultButton;
    public GameObject test1;
    ActionListener actionListener;
    Status status;
    // Start is called before the first frame update
    void Start()
    {
        actionListener = GameObject.Find("ActionListener").GetComponent<ActionListener>();
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
        Debug.Log(status.HP);
        ATBBar.SetATBBarValue(ATBBar.GetATBBarValue() + 1.0f/finalATBSpeed * Time.deltaTime);
        
        if (ATBBar.GetATBBarValue() == 1f) 
        {
            basicMenu.SetActive(true);

        }
        
    }

    IEnumerator PauseTimer()
    {
        yield return new WaitForSeconds(2);
    }
}
