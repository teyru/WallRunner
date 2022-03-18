using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LosePlates : MonoBehaviour
{
    private void OnCollisionEnter(Collision collision)
    {
        Destroy(collision.gameObject);
        PlayerController.isGrounded = false;
    }
}
