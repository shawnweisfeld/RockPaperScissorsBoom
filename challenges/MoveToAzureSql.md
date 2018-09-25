# Challenge 5 - Leverage Azure SQL Database

## Prerequisities

1. [Challenge 4 - Build a CI/CD pipeline with Azure DevOps](./BuildCICDPipelineWithAzureDevOps.md) should be done successfuly.

## Introduction

So far we have deployed a SQL Server on Linux containers which was really convenient for dev/test scenarios, especially locally. But now with this challenge we would like to leverage Azure SQL Database as a Platform-as-a-Service (PaaS) which offers out-of-the-box features we would like to leverage in Production: security patch, SQL Server upgrades, Auto-tuning, Geo-replication, Scaling up or down the size of the server, etc.

## Challenges

1. Provision your Azure SQL Database via Infrastructure-as-Code from within Azure Cloud Shell. The approach here is to leverage the Azure CLI (not the Azure portal) by executing a serie of bash commands.
2. Update your app with the new connection string, test the app as an end-user, and play a game once deployed there. The approach here is not to directly edit the app itself but more updating the Azure Web App Service.

## Success criteria

1. In Azure Cloud Shell, make sure `az sql list` is showing your Azure services properly - FIXME(mabenoit).
2. In Azure Cloud Shell, delete the previously SQL Server on Linux container deployed on Azure Web App Service.
3. In your web browser, navigate to the app and play a game, make sure it's working without any error.
4. In GitHub, make sure you documented the different commands you have used to update or provision your infrastructure. It could be in a `.md` file or in `.sh` file. You will complete this script as you are moving forward with the further labs.
5. In Azure DevOps (Boards), from the Kanban view ("FIXME(mabenoit)"), you could now drag and drop the user story associated to this Challenge to the `Done` column, congrats! ;)

## Tips

1. Azure SQL Database Service CLI documentation - FIXME(mabenoit) 
2. Azure Web App Service CLI documentation - FIXME(mabenoit)
3. You could execute the `git` commands "locally" from within your Azure Cloud Shell, or you could leverage the web editor directy from the Azure DevOps (Repos) - FIXME(mabenoit)

## Advanced challenges

Too comfortable? Eager to do more? Here you are:

1. Instead of leveraging Azure CLI to provision your infrastructure, you could leverage instead Azure ARM Templates, Ansible for Azure or Terraform for Azure.

## Learning resources

- SQL Server on Windows and Linux comparing features - FIXME(mabenoit)
- Choose between SQL Server (IaaS) or Azure SQL Database (PaaS) - FIXME(mabenoit)
- Azure CLI - FIXME(mabenoit)
- Azure ARM Templates - FIXME(mabenoit)
- Ansible for Azure - FIXME(mabenoit)
- Terraform for Azure - FIXME(mabenoit)

[Next challenge (FIXME) >](./)