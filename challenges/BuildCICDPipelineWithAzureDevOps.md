# Challenge 4 - Build a CI/CD pipeline with Azure DevOps

## Prerequisities

1. [Challenge 3 - Run the app on Azure](./RunOnAzure.md) should be done successfuly.

## Introduction

In the previous we manually deployed the app on Azure. Now with this challenge you will be able to build an entire CI/CD pipeline with Azure DevOps.

## Challenges

1. Create a Build definition with Azure Pipelines to push your associated images to your Azure Container Registry (ACR). Furthermore, enable the `Continuous Integration` feature for this Build definition.
2. Create a Release definition with Azure Pipelines to run your images on your Azure Web App Service previously provisionned. Furthermore, enable the `Continuous Devivery` feature for the Release definition.
3. Provision your Azure Web App Service via Infrastructure-as-Code from within Azure Cloud Shell. The approach here is to leverage the Azure CLI (not the Azure portal) by executing a serie of bash commands.
4. Deploy, test the app as an end-user, and play a game once deployed there.

## Success criteria

1. 
2. In Azure Cloud Shell, make sure `az web list` is showing your Azure services properly - FIXME(mabenoit).
3. In Azure Cloud Shell, make sure `az acr repository` is showing your new containers images properly - FIXME(mabenoit).
4. In GitHub, make sure you documented the different commands you have used to provision your infrastructure. It could be in a `.md` file or in `.sh` file. You will complete this script as you are moving forward with the further labs.
5. In your web browser, navigate to the app and play a game, make sure it's working without any error.
6. In Azure DevOps (Boards), from the Boards view, you could now drag and drop the user story associated to this Challenge to the `Done` column, congrats! ;)

## Tips

1. Azure Web App Service CLI documentation - FIXME(mabenoit)
2. Azure Container Registry? - FIXME(mabenoit)
3. You could execute the `git` commands "locally" from within your Azure Cloud Shell, or you could leverage the web editor directy from the Azure DevOps (Repos) - FIXME(mabenoit)

## Advanced challenges

Too comfortable? Eager to do more? Here you are:

1. Let's add the Build and Release badges on your main README.md file to have the status of them directly from there. - FIXME(mabenoit)
2. Instead of using the graphical definition of your Azure Pipelines (Builds), you could use the YAML file definition. - FIXME(mabenoit)
3. Instead of building your containers images on the VSTS Hosted agent, you could use the Azure Container Registry (ACR) Build Task feature
4. Instead of leveraging Azure Pipelines (Builds) for buidling your containers images, you could use Jenkins and generate an artifact as input of the Azure Pipelines (Releases) definition. - FIXME(mabenoit)

## Learning resources

- Azure DevOps Pipelines
- ACR Build task
- Jenkins on Azure

[Next challenge (FIXME) >](./)