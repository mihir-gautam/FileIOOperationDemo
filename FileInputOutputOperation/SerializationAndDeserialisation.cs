using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;

namespace FileInputOutputOperation
{
    public class SerializationAndDeserialisation
    {
        public string path = "abc";

        public string Name { get; private set; }
        public string Description { get; private set; }

        public void BinarySerialization()
        {
            Demo demo = new Demo();
            FileStream fileStream = new FileStream(path, FileMode.Create);
            BinaryFormatter binaryFormatter = new BinaryFormatter();
            binaryFormatter.Serialize(fileStream, demo);
            Console.ReadKey();
        }
        public void BinaryDeSerialization()
        {
            Demo demo = new Demo();
            FileStream fileStream = new FileStream(path, FileMode.Create);
            BinaryFormatter binaryFormatter = new BinaryFormatter();
            binaryFormatter.Deserialize(fileStream);
            Console.WriteLine("Application Id:{0} ", demo.ApplicationId);
            Console.WriteLine("Application Name:{0} ", demo.ApplicationName);
            Console.ReadKey();
        }
        [Serializable]
        public class Demo
        {
            public string ApplicationName { get; set; }
            public int ApplicationId { get; set; } = 1001;
        }


    }
}
