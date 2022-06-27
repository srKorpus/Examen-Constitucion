using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Cinemachine;

public class ChangeView : MonoBehaviour
{
    [Header("Room Cameras")]
    [SerializeField] CinemachineVirtualCamera mainCamera;
    [SerializeField] CinemachineVirtualCamera tvCamera;
    [SerializeField] CinemachineVirtualCamera phoneCamera;
    public CinemachineVirtualCamera cardsCamera;

    [Header("Cards Cameras")]
    public CinemachineVirtualCamera row1;
    public CinemachineVirtualCamera row2;
    public CinemachineVirtualCamera row3;
    public CinemachineVirtualCamera row4;

    [Header("Canvas Buttons")]
    [SerializeField] GameObject button1;
    [SerializeField] GameObject button2;
    [SerializeField] GameObject button3;
    [SerializeField] GameObject button4;

    [Header("On Screen Buttons")]
    public GameObject tableButton;
    public GameObject tvButton;
    public GameObject phoneButton;
    public GameObject cardsButton;
    private void Awake()
    {
        OnStart();
    }

    private void Update()
    {
        if(Input.GetKeyDown(KeyCode.Alpha1))
        {
            DefaultCamera();
        }

        if(Input.GetKeyDown(KeyCode.Alpha2))
        {
            TVCamera();
        }

        if(Input.GetKeyDown(KeyCode.Alpha3))
        {
            PhoneCamera();
        }

        if(Input.GetKeyDown(KeyCode.Alpha4))
        {
            CardsCloseUp();
        }
    }

    void OnStart()
    {
        mainCamera.Priority = 0;
        tvCamera.Priority = 40;
        phoneCamera.Priority = 0;
        cardsCamera.Priority = 0;
        row1.Priority = 0;
        row2.Priority = 0;
        row3.Priority = 0;
        row4.Priority = 0;

        button1.SetActive(true);
        button2.SetActive(true);
        button3.SetActive(true);
        button4.SetActive(true);
    }
    public void DefaultCamera()
    {
        mainCamera.Priority = 40;
        tvCamera.Priority = 0;
        phoneCamera.Priority = 0;
        cardsCamera.Priority = 0;
        row1.Priority = 0;
        row2.Priority = 0;
        row3.Priority = 0;
        row4.Priority = 0;

        button1.SetActive(true);
        button2.SetActive(true);
        button3.SetActive(true);
        button4.SetActive(true);
    }

    public void TVCamera()
    {
        mainCamera.Priority = 0;
        tvCamera.Priority = 40;
        phoneCamera.Priority = 0;
        cardsCamera.Priority = 0;

        button1.SetActive(true);
        button2.SetActive(true);
        button3.SetActive(true);
        button4.SetActive(true);
    }

    public void PhoneCamera()
    {
        mainCamera.Priority = 0;
        tvCamera.Priority = 0;
        phoneCamera.Priority = 40;
        cardsCamera.Priority = 0;

        button1.SetActive(true);
        button2.SetActive(true);
        button3.SetActive(true);
        button4.SetActive(true);
    }

    public void CardsCloseUp()
    {
        row1.Priority = 0;
        row2.Priority = 0;
        row3.Priority = 0;
        row4.Priority = 0;

        mainCamera.Priority = 0;
        tvCamera.Priority = 0;
        phoneCamera.Priority = 0;
        cardsCamera.Priority = 40;

        button1.SetActive(true);
        button2.SetActive(true);
        button3.SetActive(true);
        button4.SetActive(true);
    }
    public void FirstRow()
    {
        row1.Priority = 40;
        row2.Priority = 0;
        row3.Priority = 0;
        row4.Priority = 0;

        mainCamera.Priority = 0;
        tvCamera.Priority = 0;
        phoneCamera.Priority = 0;
        cardsCamera.Priority = 0;
        button1.SetActive(false);
        button2.SetActive(true);
        button3.SetActive(true);
        button4.SetActive(true);
    }

    public void SecondRow()
    {
        row1.Priority = 0;
        row2.Priority = 40;
        row3.Priority = 0;
        row4.Priority = 0;

        mainCamera.Priority = 0;
        tvCamera.Priority = 0;
        phoneCamera.Priority = 0;
        cardsCamera.Priority = 0;
        button1.SetActive(true);
        button2.SetActive(false);
        button3.SetActive(true);
        button4.SetActive(true);
        

    }

    public void ThirdRow()
    {
        row1.Priority = 0;
        row2.Priority = 0;
        row3.Priority = 40;
        row4.Priority = 0;

        mainCamera.Priority = 0;
        tvCamera.Priority = 0;
        phoneCamera.Priority = 0;
        cardsCamera.Priority = 0;
        button1.SetActive(true);
        button2.SetActive(true);
        button3.SetActive(false);
        button4.SetActive(true);
    }

    public void FourthRow()
    {
        row1.Priority = 0;
        row2.Priority = 0;
        row3.Priority = 0;
        row4.Priority = 40;

        mainCamera.Priority = 0;
        tvCamera.Priority = 0;
        phoneCamera.Priority = 0;
        cardsCamera.Priority = 0;
        button1.SetActive(true);
        button2.SetActive(true);
        button3.SetActive(true);
        button4.SetActive(false);
    }

    public void GoBack()
    {
        row1.Priority = 0;
        row2.Priority = 0;
        row3.Priority = 0;
        row4.Priority = 0;

        mainCamera.Priority = 0;
        tvCamera.Priority = 0;
        phoneCamera.Priority = 0;
        cardsCamera.Priority = 40;

        button1.SetActive(true);
        button2.SetActive(true);
        button3.SetActive(true);
        button4.SetActive(true);
    }
}
