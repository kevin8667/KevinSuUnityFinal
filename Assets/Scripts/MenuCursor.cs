using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuCursor : MonoBehaviour
{
    [SerializeField] AudioClip selectSFX;
    public int currentTarget = 0;
    public GameObject menuLayer;
    public GameObject skills;
    public GameObject magics;
    public GameObject items;
    public GameObject cursor;
    public Cursor cursorS;
    public GameObject basicMenu;
    string selected;
    AudioSource audioSource = null;

    // Start is called before the first frame update
    void Start()
    {
        if (TopMenu.basicActions == null)
        {
            TopMenu.basicActions = GameObject.FindGameObjectsWithTag("BasicActions");
            for (int i = 0; i < TopMenu.basicActions.Length; i++)
            {
                Debug.Log(TopMenu.basicActions[i].name);
            }
        }
        transform.position = TopMenu.basicActions[0].transform.position + new Vector3(-90, 0, 0);
        cursorS = cursor.GetComponent<Cursor>();
        audioSource = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.DownArrow) && !cursor.activeSelf)
        {
            audioSource.PlayOneShot(selectSFX);
            if (currentTarget < TopMenu.basicActions.Length - 1)
            {
                currentTarget += 1;
                transform.position = TopMenu.basicActions[currentTarget].transform.position + new Vector3(-90, 0, 0);
            }
            else if (currentTarget == TopMenu.basicActions.Length - 1)
            {
                currentTarget = 0;
                transform.position = TopMenu.basicActions[currentTarget].transform.position + new Vector3(-90, 0, 0);
            }

        }
        if (Input.GetKeyDown(KeyCode.UpArrow) && !cursor.activeSelf)
        {
            audioSource.PlayOneShot(selectSFX);
            if (currentTarget != 0)
            {
                currentTarget -= 1;
                transform.position = TopMenu.basicActions[currentTarget].transform.position + new Vector3(-90, 0, 0);
            }
            else if (currentTarget == 0)
            {
                currentTarget = TopMenu.basicActions.Length - 1;
                transform.position = TopMenu.basicActions[currentTarget].transform.position + new Vector3(-90, 0, 0);
            }

        }
        if (Input.GetButtonDown("Submit"))
        {
            audioSource.PlayOneShot(selectSFX);
            Debug.Log(TopMenu.basicActions[currentTarget].name);
            selected = TopMenu.basicActions[currentTarget].name;
            CatchingTarget.actionType = TopMenu.basicActions[currentTarget].name;

            switch (selected) 
            {
                case "Attack":
                    cursor.SetActive(true);
                    break;
                case "Skills":
                    menuLayer.SetActive(true);
                    skills.SetActive(true);
                    if (Skills.skillList == null)
                    {
                        Skills.skillList = GameObject.FindGameObjectsWithTag("Skills");
                        for (int i = 0; i < Skills.skillList.Length; i++)
                        {
                            Debug.Log(Skills.skillList[i].name);
                        }
                    }
                    gameObject.SetActive(false);
                    break;
                case "Magics":
                    menuLayer.SetActive(true);
                    magics.SetActive(true);
                    if (Magics.magicList == null)
                    {
                        Magics.magicList = GameObject.FindGameObjectsWithTag("Magics");
                        for (int i = 0; i < Magics.magicList.Length; i++)
                        {
                            Debug.Log(Magics.magicList[i].name);
                        }
                    }
                    break;
                case "Items":
                    menuLayer.SetActive(true);
                    items.SetActive(true);
                    if (Items.itemList == null)
                    {
                        Items.itemList = GameObject.FindGameObjectsWithTag("Items");
                        for (int i = 0; i < Items.itemList.Length; i++)
                        {
                            Debug.Log(Items.itemList[i].name);
                        }
                    }
                    break;
            }

        }
    }
}
