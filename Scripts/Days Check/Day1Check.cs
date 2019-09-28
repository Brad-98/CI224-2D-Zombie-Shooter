using UnityEngine;
using UnityEngine.UI;

public class Day1Check : MonoBehaviour {

   
    void Update ()
    {
        if (!GameObject.FindGameObjectWithTag("Zombie"))
        {
#pragma warning disable CS0618 // Type or member is obsolete
            Application.LoadLevel(2);
#pragma warning disable CS0618 // Type or member is obsolete
        }
    }
}
