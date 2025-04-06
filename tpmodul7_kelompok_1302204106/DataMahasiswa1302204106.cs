using System;
using System.IO;
using Newtonsoft.Json;

namespace tpmodul7_kelompok_1302204106
{
    public class DataMahasiswa1302204106
    {
        public class Nama
        {
            public string? depan { get; set; }
            public string? belakang { get; set; }
        }

        public class Mahasiswa
        {
            public Nama? nama { get; set; }
            public string? nim { get; set; }
            public string? fakultas { get; set; }
        }

        public static void ReadJSON()
        {
            string json = File.ReadAllText("tp7_1_1302204106.json");
            Mahasiswa mhs = JsonConvert.DeserializeObject<Mahasiswa>(json)!;

            Console.WriteLine($"Nama {mhs.nama?.depan} {mhs.nama?.belakang} dengan nim {mhs.nim} dari fakultas {mhs.fakultas}");
        }
    }
}