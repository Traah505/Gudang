using System;
using System.Collections.Generic;
using System.IO;
using System.Xml;
using Newtonsoft.Json;
public class DataAktivitas
{
    public DateTime Waktu { get; set; }
    public string Nama { get; set; }
    public string Peran { get; set; }
    public string Aktivitas { get; set; }
}

public static class AktivitasStore
{
    private static string filePath =
        Path.Combine(AppDomain.CurrentDomain.BaseDirectory,
        "aktivitas.json");

    public static List<DataAktivitas> AmbilSemua()
    {
        if (!File.Exists(filePath))
            return new List<DataAktivitas>();

        string json = File.ReadAllText(filePath);

        return JsonConvert.DeserializeObject<List<DataAktivitas>>(json)
               ?? new List<DataAktivitas>();
    }

    public static void Catat(string nama, string peran, string aktivitas)
    {
        List<DataAktivitas> data = AmbilSemua();

        data.Add(new DataAktivitas
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