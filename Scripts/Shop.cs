using UnityEngine;
using UnityEngine.UI;

public class Shop : MonoBehaviour
{
    public int maxHealth = 100;
    private int currHealth;

    public Text healthbar;

    // Use this for initialization
    void Start () {
        currHealth = maxHealth;
	}
	
	// Update is called once per frame
	void Update ()
    {
        healthbar.text = currHealth.ToString();

		if(currHealth <= 0)
        {
            Destroy(gameObject);
#pragma warning disable CS0618 // Type or member is obsolete
            Application.LoadLevel(11);
#pragma warning disable CS0618 // Type or member is obsolete
        }
    }

    public void DamageShop(int damage)
    {
        Debug.Log("Hit Shop");
        currHealth -= damage;
    }
}
