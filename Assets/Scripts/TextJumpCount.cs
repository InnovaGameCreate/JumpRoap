using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TextJumpCount : MonoBehaviour
{
    [SerializeField] private Text jumpCountText;

    void Start()
    {
        jumpCountText.text = StaticJumpCount.jumpCount + "かい";
    }

    private void Update()
    {
        jumpCountText.text = StaticJumpCount.jumpCount + "かい";
    }
}
