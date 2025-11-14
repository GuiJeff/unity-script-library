using System;
using UnityEngine;

public class EnemyMovement : MonoBehaviour
{
    [SerializeField] float movementSpeed = 1f;
    Rigidbody2D myRigidbody;
    BoxCollider2D myScopeCollider;
    void Start()
    {
        myRigidbody = GetComponent<Rigidbody2D>();
        myScopeCollider = GetComponent<BoxCollider2D>();
    }

    void Update()
    {
        myRigidbody.linearVelocity = new Vector2(movementSpeed, 0f);
    }

    void OnTriggerExit2D()
    {
        movementSpeed = -movementSpeed;
        FlipEnemyFacing();

    }

    void FlipEnemyFacing()
    {
        transform.localScale = new Vector2(-(Mathf.Sign(myRigidbody.linearVelocityX)), 1f);
    }
}
