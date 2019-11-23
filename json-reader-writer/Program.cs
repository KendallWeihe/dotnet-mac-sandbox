using System;
using System.IO;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace json_reader_writer
{
    class Program
    {
        static void Main(string[] args)
        {
            var filename = args[0];
            Console.WriteLine($"{nameof(filename)} = {filename}");
            
            var text = File.ReadAllText(filename);
            Console.WriteLine($"{nameof(text)} = {text}");

            var jobject = JObject.Parse(text);
            Console.WriteLine($"{nameof(jobject)} = {jobject}");

            var deserialized = JsonConvert.DeserializeObject<Sample>(text);
            Console.WriteLine($"{nameof(deserialized.Hello)} = {deserialized.Hello}");

            deserialized.World = "hello";

            var serialized = JsonConvert.SerializeObject(deserialized);
            Console.WriteLine($"{nameof(serialized)} = {serialized}");
            
            File.WriteAllText(filename, serialized);
        }
    }
}
