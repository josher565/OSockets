using System;

//https://docs.microsoft.com/en-us/aspnet/signalr/overview/deployment/tutorial-signalr-self-host
namespace OSockets
{
    class Program
    {
        static void Main(string[] args)
        {
            using (Microsoft.Owin.Hosting.WebApp.Start<Startup1>("http://localhost:9000"))
            {
                Console.WriteLine("Press [enter] to quit...");
                Console.ReadLine();
            }
        }
    }
}
