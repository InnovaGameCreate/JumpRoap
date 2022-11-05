using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JumpMove : MonoBehaviour
{
    // Start is called before the first frame update
    private Rigidbody rb;
    private bool isGound = false;
    [SerializeField] private float jumpPower;
    private RaycastHit _raycastHit;
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }
    void Update()
    {
        if (Input.GetKeyUp(KeyCode.Space) &&!isGound)
        {
            
            rb.AddForce(Vector3.up*jumpPower,ForceMode.Impulse);
            isGound = true;
        }
    }

    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.CompareTag("Ground"))
        {
            isGound = false;
        }
    }
}
