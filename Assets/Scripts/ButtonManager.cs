using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonManager : MonoBehaviour
{
    public UIManager uiManager;

    void Start()
    {
        uiManager = FindObjectOfType<UIManager>();
    }

    public void ButtonPressed()
    {
        SceneManager.LoadScene("Fps");
    }
}
