# Challenge 3 - Run the app on Azure

## Prerequisities

1. [Challenge 3 - Move to Azure SQL Database](./MoveToAzureSql.md) should be done successfuly.

## Introduction

In the previous we deployed the app on Azure but into an Azure Docker-machine playing the role of your local machine. Now with this challenge you will be able to provision an Azure Web App Service for Linux to host your "Rock Paper Scissors Boom" app.

## Challenges

1. Provision your Azure Web App Service via Infrastructure-as-Code from within Azure Cloud Shell. The approach here is to leverage the Azure CLI (not the Azure portal) by executing a serie of bash commands.
2. Deploy, test the app as an end-user, and play a game once deployed there.

## Success criteria

1. In Azure Cloud Shell, make sure `az web list` is showing your Azure services properly - FIXME(mabenoit).
2. In Azure Cloud Shell, delete the previously SQL Server on Linux container deployed on your Azure Docker-machine, by running a `docker rm` command.
3. In your web browser, navigate to the app and play a game, make sure it's working without any error.
4. In GitHub, make sure you documented the different commands you have used to provision your infrastructure. It could be in a `.md` file or in `.sh` file. You will complete this script as you are moving forward with the further labs.
5. In Azure DevOps (Boards), from the Boards view, you could now drag and drop the user story associated to this Challenge to the `Resolved` or `Closed` column, congrats! ;)

## Tips

1. Azure Web App Service CLI documentation - FIXME(mabenoit)
2. Azure Container Registry? - FIXME(mabenoit)
3. You could execute the `git` commands "locally" from within your Azure Cloud Shell, or you could leverage the web editor directy from the Azure DevOps (Repos) - FIXME(mabenoit)

## Advanced challenges

Too comfortable? Eager to do more? Here you are:

1. Instead of leveraging Azure Web App Service for Linux, you could deploy your app in Azure Container Instance (ACI) or Azure Kubernetes Service (AKS).
2. Instead of leveraging Azure CLI to provision your infrastructure, you could leverage instead Azure ARM Templates, Ansible for Azure or Terraform for Azure.

## Learning resources

- Cloud computing hosting decision tree - FIXME(mabenoit)
- Containers hosting options in Azure - FIXME(mabenoit)
- Azure CLI - FIXME(mabenoit)
- Azure ARM Templates - FIXME(mabenoit)
- Ansible for Azure - FIXME(mabenoit)
- Terraform for Azure - FIXME(mabenoit)

[Next challenge (Build a CI/CD pipeline with Azure DevOps) >](./BuildCICDPipelineWithAzureDevOps.md)