using UnityEditor;

public class BuildScript
{
    public static void PerformWindowsx64Build()
    {
        string[] targetScenes = { "Assets/Scenes/SampleScene.unity" };
        BuildPipeline.BuildPlayer(
            targetScenes,
            "./builds/Winx64/RollTheBall_x64.exe",
            BuildTarget.StandaloneWindows64,
            BuildOptions.None);
    }
}
