using DigiminJSON;
using RestSharp;
using System.Text.Json;

RestClient client = new("https://digi-api.com/api/v1");

RestRequest request = new($"digimon/38");

RestResponse response = client.GetAsync(request).Result;

Digimon d = JsonSerializer.Deserialize<Digimon>(response.Content);

Console.WriteLine(d.name);
Console.ReadLine();