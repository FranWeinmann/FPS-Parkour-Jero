using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class RespawnOnFall : MonoBehaviour
{
    public float yRespawn;
    public RespownPoint respawnPoint;
    public Transform SpawnPoint;

    void Start()
    {
        respawnPoint = FindObjectOfType<RespownPoint>();
    }

    void Update()
    {
        if (transform.position.y < yRespawn)
        {
            if (respawnPoint.zone == "New")
            {
                Debug.Log("FKEOFEJWK");
                transform.position = SpawnPoint.position;
            }
            else
            {
                SceneManager.LoadScene("Fps");
            }
        }
    }
}