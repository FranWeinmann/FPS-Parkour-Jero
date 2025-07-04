using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MenuManager : MonoBehaviour
{
    public UIManager uiManager;
    public Image menuImage;
    private bool menuOpened = false;

    void Start()
    {
        uiManager = FindObjectOfType<UIManager>();
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.M))
        {
            menuOpened = !menuOpened;
            uiManager.ShowMenu(menuOpened, menuImage);
            uiManager.CancelUserMovement(menuOpened);
        }
    }
}
