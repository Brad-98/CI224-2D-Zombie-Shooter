using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FinalDayCheck : MonoBehaviour
{

    // Update is called once per frame
    void Update()
    {
        if (!GameObject.FindGameObjectWithTag("Zombie"))
        {
#pragma warning disable CS0618 // Type or member is obsolete
            Application.LoadLevel(10);
#pragma warning disable CS0618 // Type or member is obsolete
        }
    }
}