using System;
using System.Net.Http;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace cw1
{
    class Program
    {
        static async Task Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            var website = args[0];



HttpClient httpClient = new HttpClient();

            var response = await httpClient.GetAsync(website);
            if (response.IsSuccessStatusCode)
            {

                var content = await response.Content.ReadAsStringAsync();


                var regex = new Regex("[a-z0-9]+[a-z0-9]*@[a-z]+\\.[a-z]+", RegexOptions.IgnoreCase);


                var matches = regex.Matches(content);


                foreach (var match in matches)
                {
                    Console.WriteLine(match);
                }
                
                ///
            }
            Console.ReadKey();


            

        }



       
    }
}
