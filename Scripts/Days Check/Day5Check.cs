﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Day5Check : MonoBehaviour
{

    // Update is called once per frame
    void Update()
    {
        if (!GameObject.FindGameObjectWithTag("Zombie"))
        {
#pragma warning disable CS0618 // Type or member is obsolete
            Application.LoadLevel(6);
#pragma warning disable CS0618 // Type or member is obsolete
        }
    }
}
