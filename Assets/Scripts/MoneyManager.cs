using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoneyManager : MonoBehaviour
{
    public float money;
    public UIManager uiManager;

    void Start()
    {
        uiManager = FindObjectOfType<UIManager>();
    }

    public bool UpdateMoney(float amount)
    {
        if (money + amount < 0)
        {
            //impedir la compra
            Debug.Log("Dinero insuficiente");
            return false;
        }
        else
        {
            money += amount;
            uiManager.UpdateMoneyText(money.ToString());
            return true;
        }
    }
}
