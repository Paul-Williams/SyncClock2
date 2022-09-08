using Newtonsoft.Json;

namespace WorldTimeApi;
public static class Request
{
  const string ByIpUrl = @"http://worldtimeapi.org/api/ip";

  public static async Task<Response?> UsingIpAddressAsync()
  {
    using var client = new HttpClient();
    return JsonConvert.DeserializeObject<Response>(await client.GetStringAsync(ByIpUrl));
  }


}
