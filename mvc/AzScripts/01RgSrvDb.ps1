# Nome database= DBTodoWebApi

# dalla command palette - riquadro comandi faccio Azure Sign in oppure vedi sotto(*)

# per lanciare questo script, assicurarsi di essere nella giusta cartella (del progetto mvc) e lanciarlo con i comandi 
# esempio .\AzScripts\UnattendedDb.ps1 (cartella di esempio)
# 

# Set variables for your server and database
$resourceGroupName = "RgStage"
$location = "eastus"
$adminLogin = "SQLserveruser"
$password = "Academy123!"
$serverName = "srvtodowebapistage"
$databaseName = "DbTodoWebApi"

# The ip address range that you want to allow to access your server
# todo (mio indirizzo IP qui): 

$startIp = ""
$endIp = ""

#  (*) 
Connect-AzAccount # todo aggiungo id sottoscrizione ?? 

#Install-Module -Name Az -Scope CurrentUser -Repository PSGallery -AllowClobber #da lanciare come admin se non riconosce i comandi Az

# Show randomized variables
Write-host "Resource group name is" $resourceGroupName
Write-host "Server name is" $serverName

Write-host "Creating resource group..."
   $resourceGroup = New-AzResourceGroup -Name $resourceGroupName -Location $location -Tag @{Ambiente="Stage"}
   $resourceGroup

Write-host "Creating primary server..."
    $server = New-AzSqlServer -ResourceGroupName $resourceGroupName `
    -ServerName $serverName `
    -Location $location `
    -SqlAdministratorCredentials $(New-Object -TypeName System.Management.Automation.PSCredential `
    -ArgumentList $adminLogin, $(ConvertTo-SecureString -String $password -AsPlainText -Force))
    $server    

Write-host "Configuring server firewall rule..."
$serverFirewallRule = New-AzSqlServerFirewallRule -ResourceGroupName $resourceGroupName `
    -ServerName $serverName `
    -FirewallRuleName "AllowedIPs" -StartIpAddress $startIp -EndIpAddress $endIp
$serverFirewallRule

Write-host "Creating a gen5 2 vCore serverless database..."
   $database = New-AzSqlDatabase  -ResourceGroupName $resourceGroupName `
      -ServerName $serverName `
      -DatabaseName $databaseName `
      -Edition GeneralPurpose `
      -ComputeModel Serverless `
      -ComputeGeneration Gen5 `
      -VCore 2 `
      -MinimumCapacity 2 `
      -SampleName "AdventureWorksLT"
   $database