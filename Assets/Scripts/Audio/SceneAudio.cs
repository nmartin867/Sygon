using System;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneAudio : MonoBehaviour
{
    [Tooltip("Unique identifier for this game object.")]
    [field: SerializeField]
    public string Id { get; set; }

    [Tooltip("Game object will not be destroyed when transitioning between these scenes.")]
    [field: SerializeField]
    public List<string> SceneNames { get; set; }

    private string ActiveSceneName => SceneManager.GetActiveScene().name;
    
    private void Start()
    {
        DontDestroyOnLoad(gameObject);
        SceneManager.sceneLoaded += OnSceneLoaded;
    }
    
    private void OnSceneLoaded(Scene scene, LoadSceneMode mode)
    {
        RemoveDuplicateInstances();
        
        if (!SceneNames.Contains(ActiveSceneName))
        {
            SceneManager.sceneLoaded -= OnSceneLoaded;
            DestroyImmediate(gameObject);
        }
    }
    
    private void RemoveDuplicateInstances()
    {
        var instanceLookUp = FindObjectsOfType<SceneAudio>().ToLookup(x => x.Id, x => x);
        var duplicates = instanceLookUp[Id].Where(x => x.gameObject != gameObject).ToList();
        Debug.Log($"Found {duplicates.Count} Duplicates");
        duplicates.ForEach(x => DestroyImmediate(x.gameObject));
    }
}
