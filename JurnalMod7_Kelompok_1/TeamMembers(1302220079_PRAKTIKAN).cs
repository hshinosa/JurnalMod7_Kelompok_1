using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.IO;

namespace JurnalMod7_Kelompok_1
{
    class TeamData
    {
        public List<MemberData> member { get; set; }
    }

    class MemberData
    {
        public string firstName { get; set; }
        public string lastName { get; set; }
        public string gender { get; set; }
        public int age { get; set; }
        public string nim { get; set; }
    }

    public static class DataMember
    {
        public static void ReadJSON()
        {
            string jsonString = File.ReadAllText("D:\\KPL\\JurnalMod7_Kelompok_1\\JurnalMod7_Kelompok_1\\jurnal7_2_1302220079.json");
            TeamData member = JsonSerializer.Deserialize<TeamData>(jsonString);

            for (int i = 0; i < member.member.Count; i++)
            {
                Console.WriteLine("Nama: " + member.member[i].firstName + " " + member.member[i].lastName);
                Console.WriteLine("Gender: " + member.member[i].gender);
                Console.WriteLine("Umur: " + member.member[i].age);
                Console.WriteLine("Nim: " + member.member[i].nim);
            }

        }
    }
}