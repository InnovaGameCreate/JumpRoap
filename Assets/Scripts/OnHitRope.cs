using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class OnHitRope : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Rope"))
        {
            StartCoroutine(LoadScene());
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
