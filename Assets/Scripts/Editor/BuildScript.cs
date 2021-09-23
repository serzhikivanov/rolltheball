using System;
using UnityEditor;

public class BuildScript
{
    private static string[] _targetScenes = { "Assets/Scenes/SampleScene.unity" };

    public static void PerformWindowsx64Build()
    {
        var err = BuildPipeline.BuildPlayer(
            _targetScenes,
            "./builds/Winx64/RollTheBall_x64.exe",
            BuildTarget.StandaloneWindows64,
            BuildOptions.None);

        if (err)
        {
            Console.WriteLine("Build failed with error: " + err.summary);
        }
        else
        {
            Console.WriteLine("Build artefacts saved to: " + System.IO.Path.GetFullPath("./builds/Winx64/RollTheBall_x64.exe"));
        }
    }

    public static void PerformAndroidBuild()
    {
        BuildPipeline.BuildPlayer(
            _targetScenes,
            "./builds/Winx64/RollTheBall_Android.apk",
            BuildTarget.Android,
            BuildOptions.None);
    }

    public static void PerformIOsBuild()
    {
        BuildPipeline.BuildPlayer(
            _targetScenes,
            "./builds/Winx64/RollTheBall_Android.ipa",
            BuildTarget.iOS,
            BuildOptions.None);
    }

    public static void PerformWebGLBuild()
    {
        BuildPipeline.BuildPlayer(
            _targetScenes,
            "./builds/WebGL/",
            BuildTarget.WebGL,
            BuildOptions.None);
    }
}
