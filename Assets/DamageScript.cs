using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DamageScript : MonoBehaviour
{
    public float damage = 1;
    public DamageManager damageManager;
    public Image panelImage;

    public void SetTransparency(float alpha)
    {
        Color color = panelImage.color;
        color.a = Mathf.Clamp01(alpha);
        panelImage.color = color;
    }

    void Start()
    {
        damageManager = FindObjectOfType<DamageManager>();
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
        SetTransparency(0.5f);
        yield return new WaitForSeconds(0.2f);
        SetTransparency(0f);
    }
}
