@REM Build WD Using DONET
@set MAJOR_VERSION=24

@REM Delete DLL files from previous versions
del ".\Euro Converter C#\Euro Converter\wd*.dll" /S /F /Q
rd ".\Euro Converter C#\Euro Converter\bin" /S /Q

@REM Create .csproj with reference to WDxxxNET2.DLL library from current version
type ".\build.csproj" | build_repl "XXX_VERSION_XXX" %MAJOR_VERSION% > ".\Euro Converter C#\Euro Converter\Euro Converter.csproj"

@REM Copy reference DLL
copy ".\Exe\wd%MAJOR_VERSION%0net2.dll" ".\Euro Converter C#\Euro Converter\" /Y

@REM Builds CSPROJ
Powershell.exe -executionpolicy remotesigned -File .\pshell_build.ps1

@REM Cleanup
rd ".\Euro Converter C#\Euro Converter\obj" /S /Q

@REM Copy framework DLLs
copy ".\Exe\wd*.dll" ".\Euro Converter C#\Euro Converter\bin\x86\Release" /Y

@REM Copy generated .exe file in EXE folder
copy ".\Euro Converter C#\Euro Converter\bin\x86\Release\Euro Converter.exe" ".\Exe\Euro Converter.exe" /Y