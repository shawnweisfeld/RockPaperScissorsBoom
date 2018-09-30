# Challenge 8 - Add Application Monitoring

## Prerequisities

1. [Challenge 2 - Run the App](./RunTheApp.md) should be done successfully.

## Introduction

We've got our app running, but how do we know how well it's performing? Let's instrument `Application Insights` so you can see what's happening inside the app.

## Challenges

1. You'll find the app is already wired up for Application Insights, you just need to populate app settings configuration with your own Application Insights key.
1. Once you have the key, start using the app to see metrics.

## Success criteria

1. Build a dashboard in the Azure Portal for viewing performance of the app.
1. Create a visual that tracks how long it takes for a game to execute in the app. - The app is already wired up for tracking this, just figure out how to display the visual in the dashboard.
1. In Azure DevOps (Boards), from the Boards view, you could now drag and drop the user story associated to this Challenge to the `Resolved` or `Closed` column, congrats! ;)

## Tips

* Game Duration is a Custom Metric, you should see it populate in the Visualization builder after you run a game.

## Advanced challenges

Too comfortable? Eager to do more? Try this:

* Find places throughout the applicaiton to track more telemetry.
* Create an alert based on App Insights telemetry.
* Generate an Application Map

## Learning resources
* https://docs.microsoft.com/en-us/azure/application-insights/app-insights-overview?toc=/azure/azure-monitor/toc.json

[Next challenge (FIXME) >](./)