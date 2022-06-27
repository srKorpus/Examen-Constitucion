using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Cinemachine;

public class ButtonsManager : MonoBehaviour
{
    [SerializeField] GameObject cover1;
    [SerializeField] GameObject cover2;
    [SerializeField] GameObject cover3;
    [SerializeField] GameObject cover4;

    [SerializeField] bool firstRowPressed;
    [SerializeField] bool secondRowPressed;
    [SerializeField] bool thirdRowPressed;
    [SerializeField] bool fourthRowPressed;

    GameObject camerasManagerGO;
    ChangeView changeView;

    public bool allPressed;
    private void Awake()
    {
        camerasManagerGO = GameObject.Find("CameraManager");
        changeView = camerasManagerGO.GetComponent<ChangeView>();
    }
    private void Start()
    {
        cover1.SetActive(false);
        cover2.SetActive(false);
        cover3.SetActive(false);
        cover4.SetActive(false);
    }
    public void FirstRowReady()
    {
        firstRowPressed = true;
        cover1.SetActive(true);
        changeView.cardsCamera.Priority = 40;
        changeView.row1.Priority = 0;
    }

    public void SecondRowReady()
    {
        secondRowPressed = true;
        cover2.SetActive(true);
        changeView.cardsCamera.Priority = 40;
        changeView.row2.Priority = 0;
    }

    public void ThirdRowPressed()
    {
        thirdRowPressed = true;
        cover3.SetActive(true);
        changeView.cardsCamera.Priority = 40;
        changeView.row3.Priority = 0;
    }

    public void FourthRowPressed()
    {
        fourthRowPressed = true;
        cover4.SetActive(true);
        changeView.cardsCamera.Priority = 40;
        changeView.row4.Priority = 0;
    }

    private void Update()
    {
        if(firstRowPressed && secondRowPressed && thirdRowPressed && fourthRowPressed)
        {
            allPressed = true;
        }
    }
}
