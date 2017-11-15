using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Base64Example
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a file path to encode into Base64: ");
            String fileName = Console.ReadLine();

            byte[] bytes = File.ReadAllBytes(fileName);

            String b64string = Convert.ToBase64String(bytes);

            StreamWriter writer = new StreamWriter(new FileStream(fileName + ".b64", FileMode.Create));
            writer.Write(b64string);
            writer.Flush();
            writer.Close();

            Console.Write(b64string);
            Console.ReadKey();
        }
    }
}
