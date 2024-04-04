using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace Jurnal07_1302220144
{
    class MahasiswaData
    {
        public string firstName { get; set; }
        public string lastName { get; set; }
        public string gender { get; set; }
        public int age { get; set; }
        public address address { get; set; }

        public List<kelas> courses { get; set; }
    }

    class address
    {
        public string streetAddress { get; set; }
        public string city { get; set; }
        public string state { get; set; }
    }
    class kelas
    {
        public string code { get; set; }
        public string name { get; set; }
    }

    public static class DataMahasiswa
    {
        public static void ReadJSON()
        {
            string jsonString = File.ReadAllText("C:\\Kuliah\\Coding\\C#\\Jurnal07_KPL\\JurnalMod7_Kelompok_1\\Jurnal07_1302220144\\jurnal7_1_1302220144.json");
            MahasiswaData mahasiswa = JsonSerializer.Deserialize<MahasiswaData>(jsonString);

            Console.WriteLine("Nama : " + mahasiswa.firstName + " " + mahasiswa.lastName+ " dengan gender " + mahasiswa.gender);
            Console.WriteLine("Umur : " + mahasiswa.age);
            Console.WriteLine("Alamat : " + mahasiswa.address.streetAddress + " " + mahasiswa.address.city + " " + mahasiswa.address.state);
            Console.WriteLine("Mengambil mata kuliah : ");
            for(int i = 0; i < mahasiswa.courses.Count; i++)
            {
                Console.WriteLine(mahasiswa.courses[i].code + " " + mahasiswa.courses[i].name);
            }
        }
    }

}
