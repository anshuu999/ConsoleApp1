using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string json = ConvertJson();
            Console.WriteLine(json);
            ConvertJsonToObject(json);
            Console.ReadLine();

        }
        static string ConvertJson()
        {
            Emp emp = new Emp() { Id = 1, Name = "John", Salary = 10000.ToString() };



            string json = JsonConvert.SerializeObject(emp);
            return json;
        }
        static void ConvertJsonToObject(string json)
        {
            Emp m = JsonConvert.DeserializeObject<Emp>(json);
            Console.WriteLine(m.Id);
            Console.WriteLine(m.Name);
            Console.WriteLine(m.Salary);
        }
    }

    class Emp
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Salary { get; set; }
        public Emp() { }



    }
}