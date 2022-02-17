$resourceGroupName = "RgStage"
$location = "eastus"
$appName = "appTodoWebApiMvc" #personalizzare
$planName = "plnTodoWebApiMvc"
# https://docs.microsoft.com/en-us/azure/app-service/quickstart-dotnetcore?tabs=net60&pivots=development-environment-ps


# tenere sempre vscode con il progetto mvc attivo
dotnet ef database update
Remove-Item '.\Publish' -Recurse
dotnet publish -c release -o .\Publish
# la cartella publish è pronta per il deploy

# lanciare il deploy web app
New-AzWebApp -Name $appName -Location $location -ResourceGroupName $resourceGroupName -AppServicePlan $planName

Compress-Archive -Path .\Publish\* -DestinationPath .\deploy.zip

Publish-AzWebApp -ResourceGroupName $resourceGroupName -Name $appName -ArchivePath (Get-Item .\deploy.zip).FullName -Force 

Remove-Item '.\deploy.zip' -Recurse
Remove-Item '.\Publish' -Recurse
