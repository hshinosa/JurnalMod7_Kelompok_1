using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Reflection.Metadata;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace JurnalMod7_Kelompok_1
{
    class datamhs
    {
        public Nama name { get; set; }
        public string gender { get; set; }
        public int age { get; set; }
        public address alamat { get; set; }
        public course matkul { get; set; }

    }

    class Nama
    {
        public string first { get; set; }
        public string last { get; set; }
    }

    class address
    {
        public string streetAddress { get; set; }
        public string city { get; set; }
        public string state { get; set; }
    }

    class course
    {
        public string code { get; set; }
        public string name { get; set; }
    }

    internal class DataMahasiswa_1302223124
    {
        public static void ReadJSON()
        {
            string jsonString = File.ReadAllText("C:\\Users\fadillah\\OneDrive - Telkom University\\Dokumen\\My File\\RPL\\SEMESTER 4\\Kontruksi Perangkat Lunak\\JurnalMod7_Kelompok_1\\JurnalMod7_Kelompok_1\\jurnal7_1_1302223124.json");
            datamhs mahasiswa = JsonSerializer.Deserialize<datamhs>(jsonString);

            Console.WriteLine("Nama " + mahasiswa.name.first + " " + mahasiswa.name.last);
            Console.WriteLine("gender " + mahasiswa.gender);
            Console.WriteLine("age " + mahasiswa.age);
            Console.WriteLine("address " + mahasiswa.alamat.streetAddress + " " + mahasiswa.alamat.city + " " + mahasiswa.alamat.state);
            Console.WriteLine("matkul " + mahasiswa.matkul.name + " ,code: " + mahasiswa.matkul.code);
        } 
    }
}
