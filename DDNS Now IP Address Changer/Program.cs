using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Http;
using System.Configuration;

namespace DDNS_Now_IP_Address_Changer
{
    class Program
    {
        static async Task Main(string[] args)
        {
            using (var client = new HttpClient())
            {
                try
                {
                    string user = Properties.Settings.Default.user;
                    string password = Properties.Settings.Default.password;
                    Console.WriteLine("Using Configuration");
                    Console.WriteLine("User: " + user);
                    Console.WriteLine("Password: " + password);

                    Console.WriteLine("Call Get ipify v4");
                    var resultIPV4 = await client.GetAsync(@"https://api.ipify.org");
                    var ipv4 = await resultIPV4.Content.ReadAsStringAsync();
                    Console.WriteLine("Get IPV4: " + ipv4);

                    Console.WriteLine("Call Get ipify v6");
                    var resultIPV6 = await client.GetAsync(@"https://api6.ipify.org");
                    var ipv6 = await resultIPV6.Content.ReadAsStringAsync();
                    Console.WriteLine("Get IPV6: " + ipv6);

                    string baseURL = @"https://f5.si/update.php?domain=" + user + "&password=" + password + "&ip=" + ipv4 + "&ipv6=" + ipv6;
                    Console.WriteLine("Call Get DDNS Now Update");
                    var result = await client.GetAsync(baseURL);
                    Console.WriteLine("ok");
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.ToString());
                }
                Console.WriteLine("End");
            }
        }
    }
}
