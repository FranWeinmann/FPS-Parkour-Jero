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
    public Image menuImage;

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

    public void ShowMenu(bool isItTrue)
    {
        RectTransform rt = menuImage.GetComponent<RectTransform>();

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
}
