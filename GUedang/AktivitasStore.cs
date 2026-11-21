using System;
using System.Collections.Generic;
using System.IO;
using System.Xml;
using Newtonsoft.Json;
public class DataLogAktivitas
{
    public DateTime Waktu { get; set; }
    public string Nama { get; set; }
    public string Peran { get; set; }
    public string Aktivitas { get; set; }
}

public class AktivitasStore
{
    private static string filePath =
        Path.Combine(AppDomain.CurrentDomain.BaseDirectory,
        "aktivitas.json");

    public static List<DataLogAktivitas> AmbilSemua()
    {
        if (!File.Exists(filePath))
            return new List<DataLogAktivitas>();

        string json = File.ReadAllText(filePath);

        return JsonConvert.DeserializeObject<List<DataLogAktivitas>>(json)
               ?? new List<DataLogAktivitas>();
    }
    public static void BersihkanSemua()
    {
        File.WriteAllText(
            filePath,
            JsonConvert.SerializeObject(
                new List<DataLogAktivitas>(),
                Newtonsoft.Json.Formatting.Indented
            )
        );
    }
    public static void Catat(string nama, string peran, string aktivitas)
    {
        List<DataLogAktivitas> data = AmbilSemua();

        data.Add(new DataLogAktivitas
        {
            Waktu = DateTime.Now,
            Nama = nama,
            Peran = peran,
            Aktivitas = aktivitas
        });
        File.WriteAllText(filePath,
    JsonConvert.SerializeObject(data, Newtonsoft.Json.Formatting.Indented));
    }
   
}