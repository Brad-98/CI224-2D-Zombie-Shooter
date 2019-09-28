using UnityEngine;
using System.Collections;

public class Bullet : MonoBehaviour
{
    public float speed = 5f;

    public int bulletDamage = 1;

    // Update is called once per frame
    void Update()
    {
        Vector3 pos = transform.position;

        Vector3 velocity = new Vector3(0, speed * Time.deltaTime, 0);

        pos += transform.rotation * velocity;

        transform.position = pos;
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag == "Zombie")
        {
            collision.gameObject.GetComponent<ZombieHealth>().Damage(bulletDamage);
            Destroy(gameObject);
        }
    }
}