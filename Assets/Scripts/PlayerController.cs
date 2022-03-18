using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public Rigidbody rigidBody;
    private Vector3 dir;
    private Vector3 lastJump;


    [SerializeField] BoxCollider[] colliders;

    public float speed;
    public static bool isGrounded;
    public static bool swipeMade;

    void Start()
    {
        lastJump = Vector3.zero;
        isGrounded = true;
        swipeMade = false;
        dir = new Vector3(0, -1, 0);
        SwipeDetection.SwipeEvent += OnSwipe;
    }

    private void OnSwipe(Vector2 direction)
    {
        if (rigidBody!= null && !PauseControle.pauseIsActive && isGrounded)
        {
            dir = (Vector3)direction;
            swipeMade = true;
            Move(dir);
        }
    }

    void Update()
    {
        if(StartPanel.tapMade)
        rigidBody.transform.position += new Vector3(0, 0, 1) * Time.deltaTime * speed * 1.5f;

        if (!isGrounded && !swipeMade)
        {
            Falling();
        }
    }

    private void Falling()
    {
         rigidBody.transform.position += dir * Time.deltaTime * 20;
    }

    private void Move(Vector3 direction)
    {
        if (lastJump != direction)
        {
            rigidBody.AddForce(direction * 1200);
            isGrounded = false;
        }

    }


    private void OnCollisionEnter(Collision collision)
    {
            if (dir.x != 0)
            {
                colliders[0].enabled = true;
                colliders[1].enabled = false;
            }
            else
                if (dir.y != 0)
            {
                colliders[0].enabled = false;
                colliders[1].enabled = true;
            }
            {
                lastJump = dir;
                isGrounded = true;
                swipeMade = false;
            }
    }

    private void OnCollisionExit(Collision collision)
    {
        isGrounded = false;
    }
}
