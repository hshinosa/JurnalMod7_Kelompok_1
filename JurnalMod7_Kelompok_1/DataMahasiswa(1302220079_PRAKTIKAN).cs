using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.IO;

namespace JurnalMod7_Kelompok_1
{
    class MahasiswaData
    {
        public string firstName { get; set; }
        public string lastName { get; set; }
        public string gender { get; set; }
        public int age { get; set; }
        public string fakultas { get; set; }
        public AddressData address { get; set; }
        public List<CoursesData> courses { get; set; }
    }

    class AddressData
    {
        public string streetAddress { get; set; }
        public string city { get; set; }
        public string state { get; set; }
    }
    class CoursesData
    {
        public string code { get; set; }
        public string name { get; set; }
    }

    public static class DataMahasiswa
    {
        public static void ReadJSON()
        {
            string jsonString = File.ReadAllText("D:\\KPL\\JurnalMod7_Kelompok_1\\JurnalMod7_Kelompok_1\\jurnal7_1_1302220079.json");
            MahasiswaData mahasiswa = JsonSerializer.Deserialize<MahasiswaData>(jsonString);

            Console.WriteLine("Nama: " + mahasiswa.firstName + " " + mahasiswa.lastName);
            Console.WriteLine("Gender: " + mahasiswa.gender);
            Console.WriteLine("Umur: " + mahasiswa.age);
            Console.WriteLine("Alamat: " + mahasiswa.address.streetAddress + ", " + mahasiswa.address.city + ", " + mahasiswa.address.state);
            for (int i = 0; i < mahasiswa.courses.Count; i++)
            {
                Console.WriteLine(mahasiswa.courses[i].code + " " + mahasiswa.courses[i].name);
            }
            
        }
    }
}