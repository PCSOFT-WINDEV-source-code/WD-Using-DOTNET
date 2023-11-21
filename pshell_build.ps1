$msbuild = (Get-ItemProperty hklm:\software\Microsoft\MSBuild\ToolsVersions\4.0).MSBuildToolsPath
$MyDir = [System.IO.Path]::GetDirectoryName($myInvocation.MyCommand.Definition) 
. "$msbuild\msbuild.exe" "$MyDir\Euro Converter C#\Euro Converter\Euro Converter.csproj" /t:Build /p:Configuration=Release /p:Platform=x86
