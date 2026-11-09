using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;

namespace GUedang
{
    public static class HelperJson
    {
        public static void SimpanData<T>(string namaFile, List<T> data)
        {
            string path = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, namaFile);
            var options = new JsonSerializerOptions
            {
                WriteIndented = true
            };
            string jsonString = JsonSerializer.Serialize(data, options);
            File.WriteAllText(path, jsonString);
        }
        public static List <T> BacaData<T>(string namaFile)
        {
            string path = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, namaFile);
            if (!File.Exists(path))
            {
                return new List<T>();
            }
            string jsonString = File.ReadAllText(path);
            if (string.IsNullOrEmpty(jsonString))
            {
                return new List<T>();
            }
            return JsonSerializer.Deserialize<List<T>>(jsonString) ?? new List<T>();
        }
    }
}
