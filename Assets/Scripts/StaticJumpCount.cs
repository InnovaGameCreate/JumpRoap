using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StaticJumpCount : MonoBehaviour
{
    void Awake()
    {
        DontDestroyOnLoad(this.gameObject);
    }
    public static float jumpCount  =0;
}
