using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JumpMove5 : MonoBehaviour
{
    // Start is called before the first frame update
    private Rigidbody rb;
    private Animator anim;
    private bool isGound = false;
    [SerializeField] private ParticleSystem ps;
    [SerializeField] private float jumpPower;
    private RaycastHit _raycastHit;
    [SerializeField] AudioClip sound1;
    AudioSource audioSource;
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        anim = GetComponent<Animator>();
        audioSource = GetComponent<AudioSource>();
    }
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Alpha5) && !isGound)
        {
            anim.SetBool("isIdle",false);
            anim.SetTrigger("isDown");
        }
        if (Input.GetKeyUp(KeyCode.Alpha5) &&!isGound)
        {
            audioSource.PlayOneShot(sound1);
            anim.SetTrigger("isJump");
            rb.AddForce(Vector3.up*jumpPower,ForceMode.Impulse);
            isGound = true;
            ps.Play();
        }
    }

    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.CompareTag("Ground"))
        {
            anim.SetBool("isIdle",true);
            isGound = false;
        }
    }
    
}
