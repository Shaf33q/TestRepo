using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q6___Construction_Game
{
    class Program
    {
        static void Main(string[] args)
        {
            var myHouse = new Building()
                .AddBedroom("master")
        .AddKitchen()        
        .AddBedroom("guest")
        .AddBalcony();


            var normalHouse = myHouse.Build();

            //kitchen, master room, guest room, balcony
            Console.WriteLine(normalHouse.Describe());

            myHouse.AddKitchen().AddBedroom("another");

            var luxuryHouse = myHouse.Build();

            //it only shows the kitchen after build
            //kitchen, master room, guest room, balcony, kitchen, another room
            Console.WriteLine(luxuryHouse.Describe());
            Console.Read();

        }
    }
  
    public class Building
    {
        string BuildSite = string.Empty;
        private List<string> rooms = new List<string>();
        public Building AddKitchen()
        {
            rooms.Add("kitchen");
            return this;
        }
        public Building AddBedroom(string Name)
        {
            rooms.Add(Name + " room");
            return this;
        }
        public Building AddBalcony()
        {
            rooms.Add(" balcony");
            return this;
        }
        public Building Build()
        {
            BuildSite = string.Join(", ", rooms);
            return this;
        }
        public string Describe()
        {
            return BuildSite;
        }


    }

}
