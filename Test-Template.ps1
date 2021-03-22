$shortName = "ninjamvc"
$id = "DotNetNinja.Templates.Mvc"

# Check if the template is already installed
$templates = dotnet new -l
$template = $templates | Select-String $shortName
# If installed then uninstall it
if($null -ne $template){
    Write-Host "Removing $id"
    dotnet new -u $id
}
#Build new Package
Write-Host "Building Template Package $id"
.\Build-Template.ps1

# Install Template
Write-Host "Installing new Template $id"
dotnet new -i $id