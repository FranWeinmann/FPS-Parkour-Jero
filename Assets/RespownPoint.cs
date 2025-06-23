using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RespownPoint : MonoBehaviour
{

    public string zone;

    void OnTriggerEnter(Collider collider)
    {
        zone = "New";
       
    }

}