using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    
    public string hostGameScene;
    public string joinGameScene;
    public string optionsGameScene;
    
    public void HostNewGame()
    {
        SceneManager.LoadScene(hostGameScene);
    }

    public void JoinGame()
    {
        SceneManager.LoadScene(joinGameScene);
    }
    public void OpenOptions()
    {
        SceneManager.LoadScene(optionsGameScene);
    }

    public void CloseOptions()
    {
        
    }

    public void QuitGame()
    {
        Application.Quit();
        Debug.Log("Game Quitting");
    }
}
