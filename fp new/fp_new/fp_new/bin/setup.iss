[Setup]
AppName=Siakad
AppVerName=Siakad Versi 1.0.0
AppPublisher=Kel5_IF09
AppCopyright=Copyright © 2023. Kel5_IF09
DefaultDirName={pf}\Siakad
DefaultGroupName=Siakad
OutputDir=file setup
OutputBaseFilename=SetupSiakad
DisableProgramGroupPage = yes
CreateUninstallRegKey = yes
Uninstallable = yes
UninstallFilesDir={app}\uninst
UninstallDisplayIcon={app}\Siakad.exe,0
UninstallDisplayName=Siakad
VersionInfoVersion=1.0.0.0
SetupIconFile=Setup.ico

[Languages]
Name: ina; MessagesFile: Indonesian.isl

[Tasks]
Name: desktopicon; Description: {cm:CreateDesktopIcon}; GroupDescription: {cm:AdditionalIcons}; Flags: unchecked


[Files]
;file-file aplikasi
Source: Debug\net6.0-windows\Siakad.exe; DestDir: {app}; Flags: ignoreversion
Source: Debug\net6.0-windows\Siakad.exe.config; DestDir: {app}; Flags: ignoreversion
Source: Debug\net6.0-windows\Database\siakad.db; DestDir: {app}\Database; Flags: ignoreversion

; file-file pendukung
Source: Debug\net6.0-windows\System.Data.SQLite.dll; DestDir: {app}; Flags: ignoreversion
Source: Debug\net6.0-windows\x64\SQLite.Interop.dll; DestDir: {app}\x64; Flags: ignoreversion
Source: Debug\net6.0-windows\x86\SQLite.Interop.dll; DestDir: {app}\x86; Flags: ignoreversion

Source: academic.ico; DestDir: {app}; Flags: ignoreversion

[Icons]
Name: {group}\Siakad; Filename: {app}\Siakad.exe; WorkingDir: {app}; IconFilename: {app}\academic.ico
Name: {userdesktop}\Siakad; Filename: {app}\Siakad.exe; WorkingDir: {app}; IconFilename: {app}\academic.ico; Tasks: desktopicon

[Registry]
;mencatat lokasi instalasi program, ini dibutuhkan jika kita ingin membuat paket instalasi update
Root: HKCU; Subkey: "Software\Siakad"; ValueName: "installDir"; ValueType: String; ValueData: {app}; Flags: uninsdeletevalue