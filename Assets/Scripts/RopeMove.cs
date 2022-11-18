using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class RopeMove : MonoBehaviour
{
    [Header("当たり判定のない時間")]
    [SerializeField] private float interval;
    
    [Header("当たり判定のある時間")]
    [SerializeField] private float hitTime;

    //private float jumpCount = 0;
    [SerializeField] private ParticleSystem ps;


    // Start is called before the first frame update

    private Collider _collider;
    void Start()
    {
        _collider = GetComponentInChildren<Collider>();
        StartCoroutine("HitRotation");

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    IEnumerator HitRotation()
    {
        while(true)
        {
            //_collider.enabled = false;
            yield return new WaitForSeconds(interval);
            //_collider.enabled = true;
            yield return new WaitForSeconds(hitTime);
            StaticJumpCount.jumpCount++;
            ps.Play();
   
        }
    }
}
