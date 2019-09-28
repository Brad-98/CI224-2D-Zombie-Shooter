using UnityEngine;

public class PlayerMovement : MonoBehaviour {

	public float playerSpeed = 2f; //Set player move speed

	private Rigidbody2D myRB2D; // Make a 2D rigidbody

    public int health;
    

    // Use this for initialization
    void Start () {

		myRB2D = GetComponent<Rigidbody2D> (); // Get the 2D rigidbody component
  
	}

    // Update is called once per frame
    void FixedUpdate () {

        if(Input.GetKey(KeyCode.W)|| Input.GetKey(KeyCode.UpArrow))
        {
            myRB2D.transform.Translate(0, playerSpeed * Time.deltaTime, 0);
        }

        //float horizontalAxis = Input.GetAxisRaw ("Horizontal"); // Horizontal input

		//float verticalAxis = Input.GetAxisRaw ("Vertical"); // Vertical input

		//Vector2 playerXYAxis = new Vector2 (0, verticalAxis); // X and Y axis for player to move

		//myRB2D.transform.Translate((playerXYAxis * playerSpeed)*Time.deltaTime); // Make the player move via the rigidbody
	}
}
