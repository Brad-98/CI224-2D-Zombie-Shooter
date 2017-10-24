using UnityEngine;

public class ButtonController : MonoBehaviour
{

    //Play
    public void Play()
    {
        Application.LoadLevel(1);
    }

    public void Options()
    {
        Application.LoadLevel("Options");
    }

    public void Quit()
    {
        Application.Quit();
    }
}
