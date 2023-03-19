using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Horizontal : Platforms
{
    private void OnCollisionEnter(Collision collision)
    {
        platformHealth -= 1;
        if (platformHealth <= 0)
        {
            platformBreak();
        }
    }
}
