# Challenge 10 - Leverage CDN 

## Prerequisities

1. [Challenge 4 - Run the app on Azure](./RunOnAzure.md) should be done successfully.

## Introduction

In this simple challenge you will leverage Azure CDN for serving static content.

#### What is a CDN? 

"A content delivery network (CDN) is a distributed network of servers that can efficiently deliver web content to users. CDNs store cached content on edge servers in point-of-presence (POP) locations that are close to end users, to minimize latency. [Read more](https://docs.microsoft.com/en-us/azure/cdn/cdn-overview).

## Challenges

1. Update the app's HTML to use CDN for static content rather than serving it directly from the host.
1. For this challenge you will need to update the HTML code of your application. Use an editor like VS Code or Notepad. If you're working in Azure Cloud Shell, you can invoke the Cloud Shell editor. Learn more aboug it [here](https://azure.microsoft.com/en-us/blog/cloudshelleditor/).

## Success criteria

1. The Rock/Paper/Scissors and Boom images on the home page of the app are served from CDN.

## Tips

* Getting your content into CDN is easy on Azure, especially if you're hosting your application in an Azure Web Apps. 

## Advanced challenges

Too comfortable? Eager to do more? Try this:

* Replace all the static content in your site with CDN. This includes your CSS and Javascript as well. 
* Set custom caching rules for your CDN. Verify that your cached static content is not downloaded more than once during the cache duration. You can verify this by inspecting the request with Developer Tools in most modern browsers.

## Learning resources

* [Azure CDN and Azure Web Apps](https://docs.microsoft.com/en-us/azure/cdn/cdn-add-to-web-app)



[Next challenge (FIXME) >](./)