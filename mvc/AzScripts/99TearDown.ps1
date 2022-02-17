dotnet ef database update 0

$resourceGroupName = "RgStage"

#rimozione gruppi risorse

Remove-AzResourceGroup -Name $resourceGroupName
