using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Cinemachine;

public class PlayerPositionIdentity : MonoBehaviour
{
    public GameObject Player;


    void Update()
    {
        if (Player != null)
        {
            transform.position = new Vector3(transform.position.x, transform.position.y, Player.transform.position.z);
        }

    }
}
