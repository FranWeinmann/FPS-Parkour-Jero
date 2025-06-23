using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class RespawnOnFall : MonoBehaviour
{
    public float yRespawn;
    public RespownPoint respawnPoint;
    public Transform SpawnPoint;
    public CharacterController character;

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
                character.enabled = false;
                transform.position = SpawnPoint.position;
                character.enabled = true;
            }
            else
            {
                SceneManager.LoadScene("Fps");
            }
        }
    }
}