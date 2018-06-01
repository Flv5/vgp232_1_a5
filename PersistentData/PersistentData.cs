﻿using System;
using System.IO;
using System.Xml.Serialization;

namespace PersistentData
{
    public class PersistentData
    {
        public static void Serialize<T>(T data, string path = "saveData.xml")
        {
            try
            {
                XmlSerializer serializer = new XmlSerializer(typeof(T));
                using (StreamWriter writer = new StreamWriter(path))
                {
                    serializer.Serialize(writer, data);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Cannot serialize object to type " + typeof(T).ToString());
                Console.WriteLine(ex.Message);
            }
        }

        public static T Deserialize<T>(string path)
        {
            try
            {
                XmlSerializer serializer = new XmlSerializer(typeof(T));
                using (StreamReader reader = new StreamReader(path))
                {
                    if(Directory.Exists(path))
                    {
                        return (T)serializer.Deserialize(reader);
                    }

                    return default(T);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Cannot deserialize object to type " + typeof(T).ToString());
                Console.WriteLine(ex.Message);
                return default(T);
            }
        }
    }
}
