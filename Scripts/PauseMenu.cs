using UnityEngine;

public class PauseMenu : MonoBehaviour {

    public GameObject game;
    public GameObject pauseMenu;

    public void MainMenu()
    {
    #pragma warning disable CS0618 // Type or member is obsolete
        Application.LoadLevel(0);
    #pragma warning disable CS0618 // Type or member is obsolete
    }

    void Start () {
        game = GameObject.Find("Game");
        pauseMenu = GameObject.Find("PauseMenu");
        pauseMenu.SetActive(false);
    }
	
	void Update ()
    {
		if(Input.GetKeyDown(KeyCode.Escape))
        {
            game.SetActive(false);
            pauseMenu.SetActive(true);
        }
	}  
}


