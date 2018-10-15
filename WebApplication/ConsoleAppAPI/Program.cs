using System;
using Newtonsoft.Json;
using System.Net.Http;
using System.Threading.Tasks;

namespace ConsoleAppAPI
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Run Task!");
            Task.Run(TaskAsync).Wait();
            Console.ReadLine();
        }

        static async Task TaskAsync()
        {
            Console.WriteLine("enter yall name");
            string name = Console.ReadLine();
            Console.WriteLine("email plz hehe");
            string email = Console.ReadLine();
            Console.WriteLine("what ya wanna say?");
            string message = Console.ReadLine();

            HttpClient client = new HttpClient();
            var StringContent = new StringContent(JsonConvert.SerializeObject(new Details(name, email, message)), System.Text.Encoding.UTF8, "application/json");         
            var result = await new HttpClient().PostAsync("http://localhost:49981/api/Contact", StringContent);
            var str = await result.Content.ReadAsStringAsync();
        }

        public class Details
        {
            public string Name { get; set; }
            public string Email { get; set; }
            public string Message { get; set; }

            public Details(string name, string email, string message)
            {
                this.Name = name;
                this.Email = email;
                this.Message = message;
            }

        }
    }
}
