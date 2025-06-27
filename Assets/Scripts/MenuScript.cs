using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MenuScript : MonoBehaviour
{
    public MenuManager menuManager;
    public Image panelImage;

    public void SetTransparency(float alpha)
    {
        Color color = panelImage.color;
        color.a = Mathf.Clamp01(alpha);
        panelImage.color = color;
    }

    void Start()
    {
        menuManager = FindObjectOfType<MenuManager>();
    }
}
