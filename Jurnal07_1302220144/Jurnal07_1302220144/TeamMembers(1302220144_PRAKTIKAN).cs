using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace Jurnal07_1302220144
{
    
    class TeamMembers
    {
        public List<members> members { get; set; }
    }
    class members
    {
        public string firstName { get; set; }
        public string lastName { get; set; }
        public string gender { get; set; }
        public int age { get; set; }
        public string nim { get; set; }
    }
    public static class DataMembers
    {
        public static void ReadJSON()
        {
            string jsonString = File.ReadAllText("C:\\Kuliah\\Coding\\C#\\Jurnal07_KPL\\JurnalMod7_Kelompok_1\\Jurnal07_1302220144\\jurnal7_2_1302220144.json");
            TeamMembers members = JsonSerializer.Deserialize<TeamMembers>(jsonString);

            Console.WriteLine("Team member list : ");
            for(int i = 0; i < members.members.Count; i++)
            {
                Console.WriteLine(members.members[i].nim + " " + members.members[i].firstName + " " + members.members[i].lastName + "(" + members.members[i].age + " " + members.members[i].gender  + ")");
            }
        }
    }
}
