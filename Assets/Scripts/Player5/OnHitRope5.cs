using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class OnHitRope5 : MonoBehaviour
{
    public Animator ropeAnim;

    void Start()
    {

    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Rope"))
        {
            ropeAnim.SetFloat("MovingSpeed", 0.0f);
            //StartCoroutine(LoadScene());
            Debug.Log("hit");
        }
    }

    IEnumerator LoadScene()
    {
        
        var async = SceneManager.LoadSceneAsync(2);
        async.allowSceneActivation = false;
        yield return new WaitForSeconds(2);
        async.allowSceneActivation = true;
    }
}
