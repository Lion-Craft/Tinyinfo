; -- setup.iss --
; To successfully run this installation and the program it installs,
; you must have a "x64" edition of Windows or Windows 11 on Arm.

; SEE THE DOCUMENTATION FOR DETAILS ON CREATING .ISS SCRIPT FILES!

[Setup]
AppName=Tinyinfo
AppVersion="3 Service Pack 1"
AppVerName=Tinyinfo 3 Service Pack 1
WizardStyle=modern
DefaultDirName={autopf}\Tinyinfo
DefaultGroupName=Tinyinfo
UninstallDisplayIcon={app}\Tinyinfo.exe
Compression=lzma2/ultra64
SolidCompression=yes
OutputDir=setup
OutputBaseFilename=Tinyinfo_Setup
; "ArchitecturesAllowed=x64compatible" specifies that Setup cannot run
; on anything but x64 and Windows 11 on Arm.
ArchitecturesAllowed=x64compatible
; "ArchitecturesInstallIn64BitMode=x64compatible" requests that the
; install be done in "64-bit mode" on x64 or Windows 11 on Arm,
; meaning it should use the native 64-bit Program Files directory and
; the 64-bit view of the registry.
ArchitecturesInstallIn64BitMode=x64compatible
PrivilegesRequired=lowest
AppCopyright=MIT License
LicenseFile=..\LICENSE.md

[Files]
Source: "E:\Tinyinfo\Tinyinfo\bin\x64\Release\Hardware.Info.dll"; DestDir: "{app}"; Flags: ignoreversion
Source: "E:\Tinyinfo\Tinyinfo\bin\x64\Release\INIFileParser.dll"; DestDir: "{app}"; Flags: ignoreversion
Source: "E:\Tinyinfo\Tinyinfo\bin\x64\Release\INIFileParser.xml"; DestDir: "{app}"; Flags: ignoreversion
Source: "E:\Tinyinfo\Tinyinfo\bin\x64\Release\Microsoft.Win32.Registry.dll"; DestDir: "{app}"; Flags: ignoreversion
Source: "E:\Tinyinfo\Tinyinfo\bin\x64\Release\Microsoft.Win32.Registry.xml"; DestDir: "{app}"; Flags: ignoreversion
Source: "E:\Tinyinfo\Tinyinfo\bin\x64\Release\NvAPIWrapper.dll"; DestDir: "{app}"; Flags: ignoreversion
Source: "E:\Tinyinfo\Tinyinfo\bin\x64\Release\NvAPIWrapper.xml"; DestDir: "{app}"; Flags: ignoreversion
Source: "E:\Tinyinfo\Tinyinfo\bin\x64\Release\System.CodeDom.dll"; DestDir: "{app}"; Flags: ignoreversion
Source: "E:\Tinyinfo\Tinyinfo\bin\x64\Release\System.CodeDom.xml"; DestDir: "{app}"; Flags: ignoreversion
Source: "E:\Tinyinfo\Tinyinfo\bin\x64\Release\System.Diagnostics.PerformanceCounter.dll"; DestDir: "{app}"; Flags: ignoreversion
Source: "E:\Tinyinfo\Tinyinfo\bin\x64\Release\System.Diagnostics.PerformanceCounter.xml"; DestDir: "{app}"; Flags: ignoreversion
Source: "E:\Tinyinfo\Tinyinfo\bin\x64\Release\System.Security.AccessControl.dll"; DestDir: "{app}"; Flags: ignoreversion
Source: "E:\Tinyinfo\Tinyinfo\bin\x64\Release\System.Security.AccessControl.xml"; DestDir: "{app}"; Flags: ignoreversion
Source: "E:\Tinyinfo\Tinyinfo\bin\x64\Release\System.Security.Principal.Windows.dll"; DestDir: "{app}"; Flags: ignoreversion
Source: "E:\Tinyinfo\Tinyinfo\bin\x64\Release\System.Security.Principal.Windows.xml"; DestDir: "{app}"; Flags: ignoreversion
Source: "E:\Tinyinfo\Tinyinfo\bin\x64\Release\Tinyinfo.exe"; DestDir: "{app}"; Flags: ignoreversion
Source: "E:\Tinyinfo\Tinyinfo\bin\x64\Release\Tinyinfo.exe.config"; DestDir: "{app}"; Flags: ignoreversion
Source: "E:\Tinyinfo\Tinyinfo\bin\x64\Release\Tinyinfo.exe.manifest"; DestDir: "{app}"; Flags: ignoreversion

[Icons]
Name: "{group}\Tinyinfo"; Filename: "{app}\Tinyinfo.exe"

[Run]
Filename: "{app}\Tinyinfo.exe"; Description: "Launch Tinyinfo"; Flags: postinstall nowait skipifsilent
