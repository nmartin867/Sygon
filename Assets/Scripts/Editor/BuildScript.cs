using System;
using UnityEditor;
using UnityEngine;

public class BuildScript : MonoBehaviour
{
    private static readonly string[] _clientScenes = new[]
    {
        "Assets/Scenes/Menus/MainMenu.unity", 
        "Assets/Scenes/Menus/HostGameMenu.unity", 
        "Assets/Scenes/Menus/JoinGameMenu.unity", 
        "Assets/Scenes/Menus/OptionsGameMenu.unity",
        "Assets/Scenes/GameScene.unity"
    };
    
    [MenuItem("Build/Build All")]
    public static void BuildAll()
    {
        BuildWinServer();
        BuildLxServer();
        BuildWinClient();
        BuildLxClient();
    }
    [MenuItem("Build/Build Server (Windows)")]
    public static void BuildWinServer()
    {
        var buildPlayerOptions = new BuildPlayerOptions
        {
            scenes = new []{ "Assets/Scenes/ServerScene.unity" },
            locationPathName = "Builds/Server/Windows/SygonDedicated.exe",
            target = BuildTarget.StandaloneWindows64,
            options = BuildOptions.CompressWithLz4HC,
            subtarget = (int)StandaloneBuildSubtarget.Server
        };
        
        Console.WriteLine("Building Windows Dedicated Server.");
        BuildPipeline.BuildPlayer(buildPlayerOptions);
        Console.WriteLine("Windows Dedicated Server build complete.");
    }
    [MenuItem("Build/Build Server (Linux)")]
    public static void BuildLxServer()
    {
        var buildPlayerOptions = new BuildPlayerOptions
        {
            scenes = new []{ "Assets/Scenes/ServerScene.unity" },
            locationPathName = "Builds/Server/Linux/SygonDedicated.x86_64",
            target = BuildTarget.StandaloneLinux64,
            options = BuildOptions.CompressWithLz4HC,
            subtarget = (int)StandaloneBuildSubtarget.Server
        };
        
        Console.WriteLine("Building Linux Dedicated Server.");
        BuildPipeline.BuildPlayer(buildPlayerOptions);
        Console.WriteLine("Linux Dedicated Server build complete.");
    }
    [MenuItem("Build/Build Client (Windows)")]
    public static void BuildWinClient()
    {
        var buildPlayerOptions = new BuildPlayerOptions
        {
            scenes = _clientScenes,
            locationPathName = "Builds/Client/Windows/Sygon.exe",
            target = BuildTarget.StandaloneWindows64,
            options = BuildOptions.CompressWithLz4HC
        };
        
        Console.WriteLine("Building Windows Client.");
        BuildPipeline.BuildPlayer(buildPlayerOptions);
        Console.WriteLine("Windows Client build complete.");
    }
    [MenuItem("Build/Build Client (Linux)")]
    public static void BuildLxClient()
    {
        var buildPlayerOptions = new BuildPlayerOptions
        {
            scenes = _clientScenes,
            locationPathName = "Builds/Client/Linux/Sygon.X86_64",
            target = BuildTarget.StandaloneLinux64,
            options = BuildOptions.CompressWithLz4HC
        };
        
        Console.WriteLine("Building Linux Client.");
        BuildPipeline.BuildPlayer(buildPlayerOptions);
        Console.WriteLine("Linux Client build complete.");
    }
}
