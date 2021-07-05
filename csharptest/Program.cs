using Newtonsoft.Json;
using System;
using System.IO;
using System.Xml.Linq;
using System.Xml.Serialization;

namespace csharptest
{

    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter path to test.xml or press q to quit");
            XDocument doc = null;
            string  path;
            do
            {
                path = Console.ReadLine();

                if (path == "q")
                    break;

                try
                {                    
                    doc = XDocument.Load(path);
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                    continue;
                }
                //конвертирование  с помощью библиотеки Newtonsoft.Json
                var json = JsonConvert.SerializeXNode(doc, Newtonsoft.Json.Formatting.None, true);
                //сохранение файла d директории с приложением (по умолчанию)
                File.WriteAllText("test_newtownsoft_converter.json", json);
                Console.WriteLine("saved " + Directory.GetCurrentDirectory() + @"\test_newtownsoft_converter.json");

                //конвертирование средствами .NET
                var serializer = new XmlSerializer(typeof(Root));
                using var reader = new StreamReader(path);
                var deserializedRoot = (Root)serializer.Deserialize(reader);
                reader.Close();
                var options = new System.Text.Json.JsonSerializerOptions { WriteIndented = true };
                var jsonFile = System.Text.Json.JsonSerializer.Serialize(deserializedRoot, options);
                File.WriteAllText("test_netcore_converter.json", jsonFile);
                
                Console.WriteLine("saved " + Directory.GetCurrentDirectory() + @"\test_netcore_converter.json");
            }
            while (doc == null);           
        }

    }
}
