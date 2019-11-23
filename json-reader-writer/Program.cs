using System;
using System.IO;
using Newtonsoft.Json.Linq;

namespace json_reader_writer
{
    class Program
    {
        static void Main(string[] args)
        {
            var filename = args[0];
            var text = File.ReadAllText(filename);
            var jobject = JObject.Parse(text);

            Console.WriteLine(jobject["hello"]);
        }
    }
}
