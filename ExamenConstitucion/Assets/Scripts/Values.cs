using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Values : MonoBehaviour
{
    public int value;
    ButtonsManager buttonsManager;
    bool allReady;
    public GameObject aprueboPanel;
    public GameObject rechazoPanel;

    private void Awake()
    {
        buttonsManager = GetComponent<ButtonsManager>();
    }
    private void Start()
    {
        aprueboPanel.SetActive(false);
        rechazoPanel.SetActive(false);
        value = 50;
    }
    private void Update()
    {
        allReady = buttonsManager.allPressed;

        if(allReady && value >= 51)
        {
            rechazoPanel.SetActive(true);
        }
        else if(allReady &&  value <= 50)
        {
            aprueboPanel.SetActive(true);
        }
    }

    public void Subtract10()
    {
        value -= 10;
    }

    public void Subtract20()
    {
        value -= 20;
    }

    public void Subtract30()
    {
        value -= 30;
    }

    public void Add10()
    {
        value += 10;
    }

    public void Add20()
    {
        value += 20;
    }

    public void Add30()
    {
        value += 30;
    }
}
