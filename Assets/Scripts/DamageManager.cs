using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DamageManager : MonoBehaviour
{
    public float life; // O health
    public UIManager uiManager;

    void Start()
    {
        uiManager = FindObjectOfType<UIManager>();
    }

    public bool UpdateLife(float damage)
    {
        if (life - damage < 1)
        {
            SceneManager.LoadScene("FPS Parkour");
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