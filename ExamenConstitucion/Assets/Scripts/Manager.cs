using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Manager : MonoBehaviour
{
    ChangeView changeView;
    GameObject camerasViewerGO;
    [SerializeField] GameObject startPanel;

    private void Awake()
    {
        camerasViewerGO = GameObject.Find("CameraManager");
        changeView = camerasViewerGO.GetComponent<ChangeView>();
    }
    private void Start()
    {
        startPanel.SetActive(true);
        changeView.tableButton.SetActive(false);
        changeView.tvButton.SetActive(false);
        changeView.phoneButton.SetActive(false);
        changeView.cardsButton.SetActive(false);
    }
    public void ExitGame()
    {
        Application.Quit();
        Debug.Log("Quit!");
    }    

    public void StartGame()
    {
        changeView.DefaultCamera();
        Invoke("DisableStartPanel", 2);
        changeView.tableButton.SetActive(true);
        changeView.tvButton.SetActive(true);
        changeView.phoneButton.SetActive(true);
        changeView.cardsButton.SetActive(true);
    }

    void DisableStartPanel()
    {
        startPanel.SetActive(false);
    }
}
