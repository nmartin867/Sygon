using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class BuildScript : MonoBehaviour
{
    public static void BuildAll()
    {
        
    }
    public static void BuildWinServer()
    {
        
    }
    public static void BuildLxServer()
    {
        var buildPlayerOptions = new BuildPlayerOptions();
        buildPlayerOptions.scenes = new[]
        {
            "Assets/Scenes/GameScene.unity",
            "Assets/Scenes/Menus/MainMenu.unity",
            "Assets/Scenes/Menus/HostGameMenu.unity",
            "Assets/Scenes/Menus/JoinGameMenu.unity",
            "Assets/Scenes/Menus/OptionsGameMenu.unity",
        };
        buildPlayerOptions.locationPathName = "";
        buildPlayerOptions.target = BuildTarget.StandaloneLinux64;
        buildPlayerOptions.options = BuildOptions.CompressWithLz4 | StandaloneBuildSubtarget.Server;

    }
    public static void BuildWinClient()
    {
        
    }
    
    public static void BuildLxClient()
    {
        
    }
}
