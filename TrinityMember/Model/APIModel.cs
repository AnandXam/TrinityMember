using System;

using Xamarin.Forms;

namespace TrinityMember.DataModel
{
    public class APIModel
    {

    }
    public class UserData
    {
        public string name { get; set; }
        public string place { get; set; }
        public string image { get; set; }
        public string houseno { get; set; }
        public string gender { get; set; }
        public string address { get; set; }
        public string phoneno { get; set; }
    }
    public class FamilyMembers
    {
        public int id { get; set; }
        public string name { get; set; }
        public string image { get; set; }
        public string relation { get; set; }
        public string birthday { get; set; }
        public string anniversary { get; set; }
        public string birthdate { get; set; }
    }

}

