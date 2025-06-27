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
        if (isItTrue)
        {
            Color color = menuImage.color;
            color.a = Mathf.Clamp01(1f);
            menuImage.color = color;
        }
        else
        {
            Color color = menuImage.color;
            color.a = Mathf.Clamp01(0f);
            menuImage.color = color;
        }

    }
}
