using UnityEngine.SceneManagement;
using UnityEngine;

public class MenuNavigator : MonoBehaviour
{
    [Tooltip("Scene to show on back navigation.")]
    [field: SerializeField]
    public string ExitScene { get; set; } = "MainMenu";
    
    private string ActiveSceneName => SceneManager.GetActiveScene().name;

    void Update()
    {
        if (Input.GetKey(KeyCode.Escape) && ActiveSceneName != ExitScene)
        {
            SceneManager.LoadScene(ExitScene);
        }
    }
}
