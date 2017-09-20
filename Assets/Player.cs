using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{

    public Rigidbody rb;

    float horizontal, vertical;

    Vector3 movement;

    public float speed = 5;
    
    void Start()
    {
        rb = gameObject.GetComponent<Rigidbody>();
    }
    
    void Update()
    {
        horizontal = Input.GetAxis("Horizontal");
        vertical = Input.GetAxis("Vertical");
    }

    void FixedUpdate()
    {
        movement = new Vector3(horizontal, 0, vertical);

        Vector3 targetMovement = movement * speed * Time.deltaTime;

        rb.MovePosition(transform.position + targetMovement);
    }

}
