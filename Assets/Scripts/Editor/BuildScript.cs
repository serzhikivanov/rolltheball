using System;
using System.IO;
using UnityEditor;
using UnityEditor.Build.Reporting;
using UnityEngine;

public class BuildScript
{
    private static string[] _targetScenes = { "Assets/Scenes/SampleScene.unity" };

    private const string CommonDir = "./builds";
    private const string AndroidDir = "Android";
    private const string IOSDir = "iOS";

    public static void PerformAndroidBuild()
    {
        CreateAndroidDir();

        var options = new BuildPlayerOptions()
        {
            locationPathName = Path.Combine(CommonDir, AndroidDir, "RollTheBall.apk"),
            scenes = _targetScenes,
            target = BuildTarget.Android,
            options = BuildOptions.None
        };

        PerformBuild(options);
    }

    public static void PerformIOsBuild()
    {
        CreateiOSDir();

        var options = new BuildPlayerOptions()
        {
            locationPathName = Path.Combine(CommonDir, IOSDir, "RollTheBall.ipa"),
            scenes = _targetScenes,
            target = BuildTarget.iOS,
            options = BuildOptions.None
        };

        PerformBuild(options);
    }

    private static void PerformBuild(BuildPlayerOptions options) 
    {
        BuildReport report = BuildPipeline.BuildPlayer(options);
        BuildSummary summary = report.summary;

        if (summary.result == BuildResult.Succeeded)
        {
            Debug.Log("Build succeeded: " + summary.totalSize + " bytes");
        }

        if (summary.result == BuildResult.Failed)
        {
            Debug.Log("Build failed");
            // SI: To fail build at this point - use the following line
            // EditorApplication.Exit(1);
        }
    }

    private static void CreateAndroidDir()
    {
        CreateCommonDir();

        var path = Path.Combine(CommonDir, AndroidDir);
        if (!Directory.Exists(path))
            Directory.CreateDirectory(path);
    }

    private static void CreateiOSDir()
    {
        CreateCommonDir();

        var path = Path.Combine(CommonDir, IOSDir);
        if (!Directory.Exists(path))
            Directory.CreateDirectory(path);
    }

    private static void CreateCommonDir()
    {
        if (!Directory.Exists(CommonDir))
            Directory.CreateDirectory(CommonDir);
    }
}
