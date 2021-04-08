using System.Threading.Tasks;
using RestSharp;

namespace AltMarkedDownClient.Models
{
  class ApiHelper
  {
    public static async Task<string> GetAll()
    {
      RestClient client = new RestClient("https://localhost:5001/api");
      RestRequest request = new RestRequest($"products", Method.GET);
      var response = await client.ExecuteTaskAsync(request);
      return response.Content;
    }

  }
}