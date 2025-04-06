using System;
using System.IO;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace tpmodul7_kelompok_1302204106
{
    public class DataMahasiswa21302204106
    {
        public class MataKuliah
        {
            public string? code { get; set; }
            public string? name { get; set; }
        }

        public class CourseList
        {
            public List<MataKuliah>? courses { get; set; }
        }

        public static void ReadJSON2()
        {
            string json = File.ReadAllText("tp7_2_1302204106.json");
            CourseList? list = JsonConvert.DeserializeObject<CourseList>(json);

            Console.WriteLine("Daftar Mata Kuliah:");
            if (list?.courses != null)
            {
                foreach (var course in list.courses)
                {
                    Console.WriteLine($"{course.code} - {course.name}");
                }
            }
            else
            {
                Console.WriteLine("Tidak ada data matkul.");
            }
        }
    }
}