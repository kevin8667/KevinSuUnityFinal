using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuCursor_S : MonoBehaviour
{
    [SerializeField] AudioClip cancelSFX;
    [SerializeField] AudioClip selectSFX;
    public GameObject cursor;
    public GameObject topCursor;
    public int currentTarget = 0;
    public GameObject skillMenu;
    AudioSource audioSource = null;

    private void Awake()
    {
        audioSource = GetComponent<AudioSource>();
    }

    // Start is called before the first frame update
    void Start()
    {

        //initial position
        transform.position = Skills.skillList[0].transform.position + new Vector3(-200, 0, 0);

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.RightArrow) && !cursor.activeSelf)
        {
            audioSource.PlayOneShot(selectSFX);
            if (currentTarget < Skills.skillList.Length - 1)
            {
                currentTarget += 1;
                transform.position = Skills.skillList[currentTarget].transform.position + new Vector3(-200, 0, 0);
            }
            else if (currentTarget == Skills.skillList.Length - 1)
            {
                currentTarget = 0;
                transform.position = Skills.skillList[currentTarget].transform.position + new Vector3(-200, 0, 0);
            }

        }
        if (Input.GetKeyDown(KeyCode.LeftArrow) && !cursor.activeSelf)
        {
            audioSource.PlayOneShot(selectSFX);
            if (currentTarget != 0)
            {
                currentTarget -= 1;
                transform.position = Skills.skillList[currentTarget].transform.position + new Vector3(-200, 0, 0);
            }
            else if (currentTarget == 0)
            {
                currentTarget = Skills.skillList.Length - 1;
                transform.position = Skills.skillList[currentTarget].transform.position + new Vector3(-200, 0, 0);
            }

        }
        if (Input.GetButtonDown("Submit"))
        {
            audioSource.PlayOneShot(selectSFX);
            Debug.Log(Skills.skillList[currentTarget].name);
            cursor.SetActive(true);


        }
        if (Input.GetButtonDown("Cancel"))
        {
            audioSource.PlayOneShot(cancelSFX);
            topCursor.SetActive(true);
            skillMenu.SetActive(false);
            
        }
    }
}
