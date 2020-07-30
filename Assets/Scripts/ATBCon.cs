using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ATBCon : MonoBehaviour
{

    [SerializeField] float basicATBSpeed = 10f;
    float finalATBSpeed;
    public Image aTBBar;
    public GameObject basicMenu;
    public GameObject character;
    public GameObject cursor;
    Status status;
    [SerializeField] AudioClip ATBFilled = null;
    AudioSource audioSource = null;

    private void Awake()
    {
        audioSource = GetComponent<AudioSource>();
    }

    // Start is called before the first frame update
    void Start()
    {
        status = character.GetComponent<Status>();
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
        ATBBar.SetATBBarValue(ATBBar.GetATBBarValue() + 1.0f / finalATBSpeed * Time.deltaTime);

        if (ATBBar.GetATBBarValue() == 1f)
        {
            basicMenu.SetActive(true);
            cursor.SetActive(true);

            audioSource.PlayOneShot(ATBFilled);

        }

    }
}
