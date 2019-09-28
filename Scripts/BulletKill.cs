using UnityEngine;

public class BulletKill : MonoBehaviour {

    public float timer = 1f;
	
	// Update is called once per frame
	void Update () {
        timer -= Time.deltaTime;

        if(timer <= 0)
        {
            Destroy(gameObject);
        }
	}
}
