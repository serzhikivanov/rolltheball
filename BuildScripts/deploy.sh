ECHO Cleaning up builds directory
rm -rf /builds/Winx64
ECHO Cleanup completed, starting the build
 
/opt/Unity/Editor/Unity -quit -batchmode -projectPath '../' -executeMethod BuildScript.PerformWindowsx64Build

ECHO Build finished, binaries 