using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuManager : MonoBehaviour
{
    // Función para activar menu
    public bool menuInterfaceActivator(bool mPressed)
    {
        if (mPressed)
        {
            return true;
        }
        return false;
    }

    void Update()
    {
        // Si se aprieta la tecla M, activar menú
        if (Input.GetKeyDown(KeyCode.M))
        {
            menuInterfaceActivator(true);
        }
    }
}
