using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthIncreaser : MonoBehaviour
{
    public float increasing;
    public DamageManager damageManager;
    private Rigidbody rb;

    void Start()
    {
        damageManager = FindObjectOfType<DamageManager>();
        rb = GetComponent<Rigidbody>();

        // Si la vida está en 100, dejamos el objeto inmóvil (kinematic)
        if (damageManager.life >= 100f)
        {
            rb.isKinematic = true;
        }
        else
        {
            rb.isKinematic = false;
        }
    }

    void Update()
    {
        // Opcional: si la vida cambia mientras está en escena, actualizamos el estado del Rigidbody
        if (damageManager.life >= 100f && !rb.isKinematic)
        {
            rb.isKinematic = true;
        }
        else if (damageManager.life < 100f && rb.isKinematic)
        {
            rb.isKinematic = false;
        }
    }

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            if (damageManager.life < 100f)
            {
                damageManager.UpdateLife(-increasing); // aumentar vida (curar)
                Destroy(gameObject);
            }
            else
            {
                // No hace nada, porque vida ya está full y el objeto es inmóvil
            }
        }
    }
}
