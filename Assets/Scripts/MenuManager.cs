using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MenuManager : MonoBehaviour
{
    public GameObject character; // referencia al jugador
    public UIManager uiManager;
    public Image menuImage;
    private bool isMenuOpen = false;

    void Start()
    {
        uiManager = FindObjectOfType<UIManager>();
    }

    public void CancelUserMovement()
    {
        // Activar o desactivar el FirstPersonController para pausar o reanudar control
        var fpsController = character.GetComponent<UnityStandardAssets.Characters.FirstPerson.FirstPersonController>();
        if (fpsController != null)
        {
            fpsController.enabled = !isMenuOpen;
        }

        // Control del cursor
        Cursor.lockState = isMenuOpen ? CursorLockMode.None : CursorLockMode.Locked;
        Cursor.visible = isMenuOpen;
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.M))
        {
            isMenuOpen = !isMenuOpen;
            uiManager.ShowMenu(isMenuOpen, menuImage);
        }
    }
}
