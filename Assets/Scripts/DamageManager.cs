using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class DamageManager : MonoBehaviour
{
    public float life; // O health
    public UIManager uiManager;
    public Image imagen;
    bool isDead = false;

    void Start()
    {
        uiManager = FindObjectOfType<UIManager>();
    }

    public bool UpdateLife(float damage)
    {
        if (life - damage < 1)
        {
            isDead = true;
            uiManager.UpdateLifeText(0.ToString());
            uiManager.ShowMenu(true, imagen);
            uiManager.CancelUserMovement(isDead);
            return false;
        }
        else
        {
            life -= damage;
            uiManager.UpdateLifeText(life.ToString());
            return true;
        }
    }
}