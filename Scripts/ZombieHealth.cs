using UnityEngine;

public class ZombieHealth : MonoBehaviour
{
    public int zombieHealth = 2;
    private int currentZombieHealth;

    public GameObject bloodPrefab;


    // Use this for initialization
    void Start ()
    {
        currentZombieHealth = zombieHealth;
        
	}
	
	// Update is called once per frame
	void Update ()
    {
        


        if (currentZombieHealth <= 0)
        {
            Destroy(gameObject);
            Instantiate(bloodPrefab, transform.position, transform.rotation);

        }
        
    }

    public void Damage(int damage)
    {
        Debug.Log("Hit");
        currentZombieHealth -= damage;
    }
}
