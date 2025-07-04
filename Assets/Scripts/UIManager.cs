using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    public TextMeshProUGUI txtMoney;
    public TextMeshProUGUI txtLife;
    public Image panelImage;
    public GameObject character; // referencia al jugador

    public void UpdateMoneyText(string money)
    {
        txtMoney.text = "$" + money;
    }

    public void UpdateLifeText(string life)
    {
        txtLife.text = "Life: " + life;
    }

    public void SetTransparency(float alpha)
    {
        Color color = panelImage.color;
        color.a = Mathf.Clamp01(alpha);
        panelImage.color = color;
    }

    public void ShowMenu(bool isItTrue, Image menuOption)
    {
        RectTransform rt = menuOption.GetComponent<RectTransform>();

        if (isItTrue)
        {
            // Menú visible: top = 0, bottom = 0
            rt.offsetMin = new Vector2(rt.offsetMin.x, 0);
            rt.offsetMax = new Vector2(rt.offsetMax.x, 0);
        }
        else
        {
            // Menú oculto: puedes ajustar estos valores para esconderlo
            rt.offsetMin = new Vector2(rt.offsetMin.x, 350);
            rt.offsetMax = new Vector2(rt.offsetMax.x, 0);
        }
    }

    public void CancelUserMovement(bool isMenuOpen)
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
}
