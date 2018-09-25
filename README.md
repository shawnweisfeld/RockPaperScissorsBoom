#Welcome to the Azure App Dev Hack!

It's a challenge based and not a step-by-step lab, but don't worry you will do great whatever your experience is! You will be guided through different labs to bonify the given "Rock Paper Scissors Boom" app by leveraging Azure PaaS services. The intent is having you practicing with our tools, technologies and services. Let's try to go out of your comfort zone, try and learn new stuffs, and for sure let's have fun!

You could do this on your own or by being part of a team, it's up to you. We would like to see a lot of collaboration and creativity!

And don't forget there is proctors around you, just raise your hand at any time!

Here are the technologies and services you will leverage:
- GitHub
- Git
- Linux
- ASP.NET Core
- SQL Server on Linux
- Docker
- Azure DevOps (formerly known as VSTS)
- Azure App Service on Linux
- Azure Container Registry
- Azure Application Insights
- Azure SQL Database

## Challenges

- [1 - Setup](./challenges/Setup.md)
- [2 - Run the app](./challenges/RunTheApp.md)
- [3 - Run the app on Azure](./challenges/RunOnAzure.md)
- [4 - Build a CI/CD pipeline with Azure DevOps](./challenges/BuildCICDPipelineWithAzureDevOps.md)
- [5 - Leverage Azure SQL Database](./challenges/MoveToAzureSql.md)

## About the Rock Paper Scissors Boom app

Rock Paper Scissors Boom is a collaborative competition among developers. It's based on a project idea from a Microsoft Developer Evangelist that was called "Rock Paper Azure".

This server project provides an API that developers can use to develop bots that play the Rock Paper Sissors Boom game.

Rules of the Game:
 * A match is played between two bots and will consist of 1000 rounds of Rock-Paper-Scissors
 * Rock beats Scissors
 * Scissors beats Paper
 * Paper beats Rock
 * A dynamite will defeat Rock, Paper, or Scissors played by the opponent.
 * A water balloon will defeat a dynamite.
 * Rock, Paper, and Scissors all beat water balloon.
 * Each bot receives 100 sticks of dynamite to use during a match.
 * All matching choices will be a tie with the same choice by opponent.
 * Each bot may also throw a water balloon whenever it likes.

![game uml](docs/game_diagram.png)


