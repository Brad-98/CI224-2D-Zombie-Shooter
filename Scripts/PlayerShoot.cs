using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerShoot : MonoBehaviour {

    public GameObject bulletPrefab;

	// Update is called once per frame
	void Update () {
		if(Input.GetMouseButtonDown(0))
        {
            Vector3 offset = transform.rotation * new Vector3(0, 0.7f, 0);
            Instantiate(bulletPrefab, transform.position + offset, transform.rotation);
        }
	}
}
