using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonManager : MonoBehaviour
{
    public void StartGame()
    {
        //when the button is clicked, load the game scene
        SceneManager.LoadScene("Game");
    }
}
