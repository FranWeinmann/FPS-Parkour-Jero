using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class UIManager : MonoBehaviour
{
    public TextMeshProUGUI txtMoney;
    public TextMeshProUGUI txtLife;

    public void UpdateMoneyText(string money)
    {
        txtMoney.text = "$" + money;
    }
    public void UpdateLifeText(string life)
    {
        txtLife.text = "Life: " + life;
    }
}
