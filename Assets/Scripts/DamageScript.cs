using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DamageScript : MonoBehaviour
{
    public float damage = 1;
    public DamageManager damageManager;
    public UIManager uiManager;

    void Start()
    {
        damageManager = FindObjectOfType<DamageManager>();
        uiManager = FindObjectOfType<UIManager>();
    }

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            if (damageManager.UpdateLife(damage))
            {
                StartCoroutine(ShowDamageEffect());
            }
        }
    }

    IEnumerator ShowDamageEffect()
    {
        uiManager.SetTransparency(0.5f);
        yield return new WaitForSeconds(0.2f);
        uiManager.SetTransparency(0f);
    }
}
