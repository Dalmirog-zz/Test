using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using Octopus.Client.Model;

namespace RESTTest
{

    class Program
    {
        static void Main()
        {
            RunAsync().Wait();
        }

        static async Task RunAsync()
        {
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri("http://localhost:81/");
                //client.DefaultRequestHeaders.Accept.Clear();
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

                HttpResponseMessage response = await client.GetAsync("/api/feeds/feeds-testfeed?apiKey=API-YHMOPNVMRLFXJBV4EQWWFKXAWLQ");
                if (response.IsSuccessStatusCode)
                {
                    FeedResource feed = await response.Content.ReadAsAsync<FeedResource>();
                    Console.WriteLine("{0}", feed.FeedUri);
                }
            }
        }
    }
}

