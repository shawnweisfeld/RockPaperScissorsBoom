# Challenge 1 - Setup

## Prerequisities

1. Your laptop: Win, MacOS or Linux
2. Your GitHub account, if not yet it's time to create one! ;)
3. Your Azure Subscription
4. Your Azure DevOps account, if not yet it's time to create one! ;)

## Introduction

With this first challenge you will be able to setup the environment required to run all the further challenges. You will leverage Azure Cloud Shell and an Azure Docker Machine instead of your local machine for any command you will need. In other word, you just need a web browser and an internet connection on your laptop. Furthermore, you will be able to create the associated Azure DevOps project to manage first your backlog, and your builds, releases and tests in further labs.
*The use of Azure Cloud Shell is our recommendation to simplify your experience. But if you prefer using your local machine to do the lab, feel free to do it. Based on our experience, the setup of Docker on local machine (which is required for the labs) could take some time and could have some issues.*

## Challenges

1. Fork this repo in your GitHub account
2. Clone your repo in Azure Cloud Shell
3. Change your current branch to `ocp-hack` - FIXME(mrichter), it should be on `master`
4. Setup an Azure Docker Machine to be used through your Azure Cloud Shell
5. Create a new Azure DevOps project (with Git and Agile template)
  - The source code will be in GitHub, but the rest (backlog, build, release and tests) will be in Azure DevOps.
6. Populate your backlog with user stories (backlog items). One user story per challenge.

## Success criteria

1. In Azure Cloud Shell, make sure `git status` is showing you the proper branch
2. In Azure Cloud Shell, make sure `docker images` command runs successfuly (without error).
3. In Azure Cloud Shell, make sure `docker-machine list` is showing you your Docker-machine successfuly (without error).
4. In Azure DevOps (Boards), make sure you have your backlog populated. From the Kanban view ("FIXME(mabenoit)"), you could now drag and drop this user story associated to this Challenge to the `Done` column, congrats! ;)
5. (Optional) In Azure Cloud Shell, let's play with the following commands: `ls -la`, `git version`, `az --version`, `docker images`, `code .`, etc.

## Tips

1. In Azure Cloud Shell, you will leverage the `Bash (CLI)` mode, we all love Linux! <3
2. To create an Azure Docker Machine, follow [these instructions-FIXME(mabenoit)]()
3. To populate your Azure Boards (Kanban) in Azure DevOps you could import [this file-FIXME(mabenoit)]()

## Advanced challenges

Too comfortable? Eager to do more? Here you are:

1. Instead of leveraging Azure Cloud Shell and an Azure Docker Machine to build your Docker images and run them, you could do that locally on your laptop by installing Docker CE and Docker-compose.
2. Instead of leveraging GitHub to host your source code, you could leverage Azure Repos (Git) in Azure DevOps.

## Learning resources

- Visual Studio Code embedded in Azure Cloud Shell - FIXME(mabenoit)
- Visual Studio Team Services (VSTS) became Azure DevOps - FIXME(mabenoit)
- Microsoft acquired GitHub - FIXME(mabenoit)
- Open Source (OSS) at Microsoft - FIXME(mabenoit)

[Next challenge (Run the App)>](./RunTheApp.md)