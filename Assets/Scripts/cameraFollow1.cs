using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cameraFollow1 : MonoBehaviour
{
    private Transform player;

    void Start()
    {
        player = GameObject.Find("Avião").transform;
    }

    void Update()
    {
        Vector3 playerpos = player.position;
        playerpos.y = 0;
        playerpos.z = transform.position.z;
        transform.position = playerpos;
    }
}