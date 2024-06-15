# Set Working Directory
Split-Path $MyInvocation.MyCommand.Path | Push-Location
[Environment]::CurrentDirectory = $PWD

./Publish.ps1 -ProjectPath "gbfr.model.weaponSwap/gbfr.model.weaponSwap.csproj" `
              -PackageName "gbfr.model.weaponSwap" `
              -PublishOutputDir "Publish/ToUpload/weaponSwap" 
			  
./Publish.ps1 -ProjectPath "gbfr.model.weaponSwap/gbfr.model.weaponSwapNoRestrictions.csproj" `
              -PackageName "gbfr.model.weaponSwapNoRestrictions" `
              -PublishOutputDir "Publish/ToUpload/weaponSwapNoRestrictions" 

# Restore Working Directory  
Pop-Location