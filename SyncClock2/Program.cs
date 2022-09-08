using WorldTimeApi;

namespace SyncClock2;

internal class Program
{
  static async Task Main(string[] args)
  {
    using var client = new HttpClient();

    Console.WriteLine("Requesting the local date and time from worldtimeapi.org server.");

    if (await Request.UsingIpAddressAsync() is Response response)
    {
      Console.WriteLine("Setting system clock.");
      SystemClock.Set(response.LocalDateTime);
    }
    else Console.WriteLine("No response was received.");

  }
}
