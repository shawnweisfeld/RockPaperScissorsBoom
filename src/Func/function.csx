#r "Microsoft.Azure.EventGrid"
#r "System.Net.Http"
using Microsoft.Azure.EventGrid.Models;

public static void Run(EventGridEvent eventGridEvent, ILogger log)
{
    log.LogInformation(eventGridEvent.Subject.ToString());
    log.LogInformation(eventGridEvent.Data.ToString());

    var url = "https://prod-40.eastus.logic.azure.com:443/workflows/be921a422b0c47b2bdcca24d169feea3/triggers/manual/paths/invoke?api-version=2016-10-01&sp=%2Ftriggers%2Fmanual%2Frun&sv=1.0&sig=qBidwvZzY50Lwj3Ehb50Bj16Gjoy0c-5rzHkOZNtwho";
    HttpClient Client = new HttpClient();
    var content = new StringContent(eventGridEvent.Data.ToString(), System.Text.Encoding.UTF8, "application/json");
    var r = Client.PostAsync(url, content).Result;
}
