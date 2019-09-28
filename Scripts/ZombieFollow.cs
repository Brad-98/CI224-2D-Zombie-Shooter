using UnityEngine;

public class ZombieFollow : MonoBehaviour
{

	public float zombieSpeed = 1;
    public int zombieDamage = 5;

    public float attackTimer = 2;
    public float attackTimerDelay;

    Transform target;

	// Use this for initialization
	void Start ()
    {
		target = GameObject.Find("Shop").transform;
	}

	// Update is called once per frame
	void Update ()
    {
		transform.LookAt(target.position);
		transform.Rotate(new Vector3 (0, -90, 0));

		transform.Translate (new Vector2 (zombieSpeed * Time.deltaTime, 0));
    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.name == "Shop")
        {
            Debug.Log("Stop");
            zombieSpeed = 0;  
        }
    }

    void OnTriggerStay2D(Collider2D collision)
    {
        if (attackTimerDelay <= 0)
        {
            attackTimerDelay = 0;
        }

        if (attackTimerDelay > 0)
        {
            attackTimerDelay -= Time.deltaTime;
        }

        if (collision.gameObject.name == "Shop")
        {
            if (attackTimerDelay == 0)
            {
                collision.gameObject.GetComponent<Shop>().DamageShop(zombieDamage);
                attackTimerDelay = attackTimer;
            }
        }
    }
}
