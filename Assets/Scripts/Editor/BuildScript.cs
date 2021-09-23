using System.IO;
using UnityEditor;

public class BuildScript
{
    private static string[] _targetScenes = { "Assets/Scenes/SampleScene.unity" };

    private const string CommonDir = "./builds";
    private const string AndroidDir = "Android";
    private const string IOSDir = "iOS";

    public static void PerformAndroidBuild()
    {
        CreateAndroidDir();

        BuildPipeline.BuildPlayer(
            _targetScenes,
            "./builds/Android/RollTheBall.apk",
            BuildTarget.Android,
            BuildOptions.None);
    }

    public static void PerformIOsBuild()
    {
        CreateiOSDir();

        BuildPipeline.BuildPlayer(
            _targetScenes,
            "./builds/iOS/RollTheBall.ipa",
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
