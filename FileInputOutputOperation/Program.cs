using System;
using System.IO;

namespace FileInputOutputOperation
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the File Input Output program in C#");
            Console.WriteLine("\n=====================================================================================");
            FileExists();
            Console.WriteLine("\n=====================================================================================");
            ReadAllLines(); 
            Console.WriteLine("\n=====================================================================================");
            ReadAllText();
            Console.WriteLine("\n=====================================================================================");
            FileCopy();
            Console.WriteLine("\n=====================================================================================");
            DeleteFile();
            Console.WriteLine("\n=====================================================================================");
            ReadFromStreamReader();
            Console.WriteLine("\n=====================================================================================");
            WriteUsingStreamWriter();
            Console.WriteLine("\n=====================================================================================");
            
            SerializationAndDeserialisation SD = new SerializationAndDeserialisation();
            SD.BinarySerialization();
            Console.WriteLine("\n=====================================================================================");
            SD.BinaryDeSerialization();
            Console.WriteLine("\n=====================================================================================");
        }
        public static void FileExists()
        {
            string path = @"C:\Users\Mihir Gautam\source\repos\FileInputOutputOperation\FileInputOutputOperation\Sample.txt";
            if (File.Exists(path))
            {
                Console.WriteLine("File Exists");
            }
        }
        public static void ReadAllLines()
        {
            string path = @"C:\Users\Mihir Gautam\source\repos\FileInputOutputOperation\FileInputOutputOperation\Sample.txt";
            string[] lines;
            lines = File.ReadAllLines(path);
            Console.WriteLine("Read All Lines");
            Console.WriteLine(lines[0]);
            Console.WriteLine(lines[1]);
        }
        public static void ReadAllText()
        {
            string path = @"C:\Users\Mihir Gautam\source\repos\FileInputOutputOperation\FileInputOutputOperation\Sample.txt";
            string lines;
            lines = File.ReadAllText(path);
            Console.WriteLine("Read All Text");
            Console.WriteLine(lines);
        }
        public static void FileCopy()
        {
            string path = @"C:\Users\Mihir Gautam\source\repos\FileInputOutputOperation\FileInputOutputOperation\Sample.txt";
            string copypath = @"C:\Users\Mihir Gautam\source\repos\FileInputOutputOperation\FileInputOutputOperation\SampleCopy.txt";

            File.Copy(path, copypath);
            Console.WriteLine("File successfuly copied");
        }
        public static void DeleteFile()
        {
            string path = @"C:\Users\Mihir Gautam\source\repos\FileInputOutputOperation\FileInputOutputOperation\SampleCopy.txt";
            File.Delete(path);
            Console.WriteLine("file successfully deleted");
        }
        public static void ReadFromStreamReader()
        {
            Console.WriteLine("Read from stream reader");
            string path = @"C:\Users\Mihir Gautam\source\repos\FileInputOutputOperation\FileInputOutputOperation\Sample.txt";
            using(StreamReader sr = File.OpenText(path))
            {
                string s = "";
                while ((s = sr.ReadLine())!=null)
                    {
                    Console.WriteLine(s);
                }
            
            }
            
        }
        public static void WriteUsingStreamWriter()
        {
            Console.WriteLine("Write using stream writer");
            string path = @"C:\Users\Mihir Gautam\source\repos\FileInputOutputOperation\FileInputOutputOperation\Sample.txt";
             using (StreamWriter sr = File.AppendText(path))
            {
                sr.WriteLine(" Welcome all - Have a good day");
                sr.Close();

                Console.WriteLine(File.ReadAllText(path));
            }
        }
    }
}
