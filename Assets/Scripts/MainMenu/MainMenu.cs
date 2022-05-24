using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    
    public string hostGameScene;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    
    public void HostNewGame()
    {
        SceneManager.LoadScene(hostGameScene);
    }

    public void OpenOptions()
    {
        
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
