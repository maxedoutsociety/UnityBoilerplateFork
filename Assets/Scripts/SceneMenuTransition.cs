using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneMenuTransition : MonoBehaviour
{
    public void GoToLevel1()
    {
        SceneManager.LoadScene("GameScene");
    }

    public void ExitGame()
    {
        Application.Quit();
    }

    public void GoToTitle()
    {
        SceneManager.LoadScene("MenuScreen");
    }
}
