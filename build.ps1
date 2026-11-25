$ErrorActionPreference = 'Stop'
Set-Location -LiteralPath $PSScriptRoot
$csc = Join-Path $env:WINDIR 'Microsoft.NET/Framework64/v4.0.30319/csc.exe'
New-Item -ItemType Directory -Force -Path dist | Out-Null
& $csc /nologo /target:winexe /optimize+ /reference:System.Windows.Forms.dll /resource:template.html,template.html /out:dist/ChatIllustration.exe Launcher.cs
if ($LASTEXITCODE -ne 0) { throw 'Compilation failed' }
