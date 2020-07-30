using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CatchingTarget : MonoBehaviour
{
    [SerializeField] AudioClip selectSFX;
    public Button targetButton;
    public GameObject cursor;
    static public GameObject[] targetList;
    Cursor cursorS;
    public static string actionType;
    AudioSource audioSource = null;
    // Start is called before the first frame update

    private void Awake()
    {
        if (targetList == null)
        {
            targetList = GameObject.FindGameObjectsWithTag("Enemy");
            for (int i = 0; i < targetList.Length; i++) 
            {
                Debug.Log(targetList[i].name);
            }
        }
        audioSource = GetComponent<AudioSource>();

    }

    // Update is called once per frame
    void Update()
    {
        if (cursor == null)
        {
            cursor = GameObject.FindGameObjectWithTag("Cursor");

        }
        cursorS = cursor.GetComponent<Cursor>();
        if (Input.GetButtonDown("Submit") && cursor.activeSelf)
        {
            audioSource.PlayOneShot(selectSFX);
            Debug.Log(TargetSelect().name);
            switch (actionType)
            {
                case "Attack":
                    Attack.ATK(GameObject.Find("PlayerCha1").GetComponent<Status>().STR, TargetSelect());
                    ATBBar.SetATBBarValue(0f);
                    GameObject.Find("BasicActions").SetActive(false);
                    cursor.SetActive(false);
                    break;
                case "Skills":
                    ATBBar.SetATBBarValue(0f);
                    GameObject.Find("SkillMenu").SetActive(false);
                    GameObject.Find("BasicActions").SetActive(false);
                    cursor.SetActive(false);
                    break;
                case "Magics":
                    ATBBar.SetATBBarValue(0f);
                    GameObject.Find("MagicMenu").SetActive(false);
                    GameObject.Find("BasicActions").SetActive(false);
                    cursor.SetActive(false);
                    break;
                case "Items":
                    ATBBar.SetATBBarValue(0f);
                    GameObject.Find("ItemMenu").SetActive(false);
                    GameObject.Find("BasicActions").SetActive(false);
                    cursor.SetActive(false);
                    break;

            }

        }
       
        
    }

    public GameObject TargetSelect()
    {
       
        return targetList[cursorS.currentTarget];

    }


}
