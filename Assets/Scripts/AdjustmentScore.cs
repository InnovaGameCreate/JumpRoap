using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AdjustmentScore : MonoBehaviour
{
    void Start()
    {
        StaticJumpCount.jumpCount -= 1;
    }

}
