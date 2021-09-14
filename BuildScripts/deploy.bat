@ECHO OFF 
@ECHO Please update Unity.exe path per your system if necessary
SET UNITY_PATH="C:\Program Files\2019.4.27f1\Editor\Unity.exe"
@ECHO Unity path is %UNITY_PATH% 

@ECHO Cleaning up builds directory
rmdir /S /Q ..\builds
@ECHO Cleanup completed, starting the build
 
%UNITY_PATH% -quit -batchmode -projectPath "..\" -executeMethod BuildScript.PerformWindowsx64Build

@ECHO Build finished, binaries 