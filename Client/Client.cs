using System;
using System.Net.Http;
using System.Threading.Tasks;

namespace KameraAPI.Client
{
    public class Client
    {
        public Client()
        {
            Task.Run(() => this.Startup()).Wait();
        }

        public async Task Startup()
        {
            HttpClient client = new HttpClient();
            HttpResponseMessage response = await client.GetAsync("http://192.168.2.212:8080/ccapi/ver100/deviceinformation");
            Console.WriteLine((await response.Content.ReadAsStringAsync()));
        }
    }
}