# Set Working Directory
Split-Path $MyInvocation.MyCommand.Path | Push-Location
[Environment]::CurrentDirectory = $PWD

Remove-Item "$env:RELOADEDIIMODS/gbfr.model.weaponSwap/*" -Force -Recurse
dotnet publish "./gbfr.model.weaponSwap.csproj" -c Release -o "$env:RELOADEDIIMODS/gbfr.model.weaponSwap" /p:OutputPath="./bin/Release" /p:ReloadedILLink="true"

# Restore Working Directory
Pop-Location