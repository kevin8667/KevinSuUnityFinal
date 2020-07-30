using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuCursor_M : MonoBehaviour
{
    [SerializeField] AudioClip cancelSFX;
    [SerializeField] AudioClip selectSFX;
    public GameObject cursor;
    public GameObject topCursor;
    public int currentTarget = 0;
    public GameObject magicMenu;
    AudioSource audioSource = null;

    private void Awake()
    {
        audioSource = GetComponent<AudioSource>();
    }

    // Start is called before the first frame update
    void Start()
    {

        //initial position
        transform.position = Magics.magicList[0].transform.position + new Vector3(-200, 0, 0);

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.RightArrow) && !cursor.activeSelf)
        {
            audioSource.PlayOneShot(selectSFX);
            if (currentTarget < Magics.magicList.Length - 1)
            {
                currentTarget += 1;
                transform.position = Magics.magicList[currentTarget].transform.position + new Vector3(-200, 0, 0);
            }
            else if (currentTarget == Magics.magicList.Length - 1)
            {
                currentTarget = 0;
                transform.position = Magics.magicList[currentTarget].transform.position + new Vector3(-200, 0, 0);
            }

        }
        if (Input.GetKeyDown(KeyCode.LeftArrow) && !cursor.activeSelf)
        {
            audioSource.PlayOneShot(selectSFX);
            if (currentTarget != 0)
            {
                currentTarget -= 1;
                transform.position = Magics.magicList[currentTarget].transform.position + new Vector3(-200, 0, 0);
            }
            else if (currentTarget == 0)
            {
                currentTarget = Magics.magicList.Length - 1;
                transform.position = Magics.magicList[currentTarget].transform.position + new Vector3(-200, 0, 0);
            }

        }
        if (Input.GetButtonDown("Submit"))
        {
            audioSource.PlayOneShot(selectSFX);
            Debug.Log(Magics.magicList[currentTarget].name);
            cursor.SetActive(true);


        }
        if (Input.GetButtonDown("Cancel"))
        {
            audioSource.PlayOneShot(cancelSFX);
            topCursor.SetActive(true);
            magicMenu.SetActive(false);

        }
    }
}
