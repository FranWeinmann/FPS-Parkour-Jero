using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FinishedPoint : MonoBehaviour
{
    public UIManager uiManager;
    public Image message;
    bool llego = true;
    void Start()
    {
        uiManager = FindObjectOfType<UIManager>();
    }

    void OnTriggerEnter(Collider collider)
    {
        uiManager.ShowMenu(llego, message);
        uiManager.CancelUserMovement(llego);
    }
}
