using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoxBehaviour : MonoBehaviour
{
    [Header("Movement")]
    public bool isGrounded;


    public RigidBody3D body;
    public CubeBehaviour cube;

    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        _Move();
    }
    private void _Move()
    {
        if (isGrounded)
        {
            body.velocity = Vector3.Lerp(body.velocity, Vector3.zero, 0.9f);
            body.velocity = new Vector3(body.velocity.x, 0.0f, body.velocity.z); // remove y
            transform.position += body.velocity;
        }
    }

    void FixedUpdate()
    {
        GroundCheck();
    }

    private void GroundCheck()
    {
        isGrounded = cube.isGrounded;
    }
}
