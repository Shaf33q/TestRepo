using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace Q4_Alexa_Settings
{
    class Program
    {
        static void Main(string[] args)
        {
            var alexa = new Alexa();
            Console.WriteLine(alexa.Talk()); //print hello, i am Alexa

            alexa.Configure(x => 
            {
                x.GreetingMessage = "Hello {OwnerName}, I'm at your service";
                x.OwnerName = "Bob Marley";
            });

            Console.WriteLine(alexa.Talk()); //print Hello Bob Marley, I'm at your service

            Console.WriteLine("press any key to exit ...");
            Console.ReadKey();

        }
        
       

}
    class Alexa
    {
        static string Mesg = "hello, i am Alexa";
        private Setting _p = new Setting();
        public class Setting
        {
            public string GreetingMessage { get; set; }
            public string OwnerName { get; set; }
        }
        static void SetMessage(Setting setting)
        {
            Mesg = setting.GreetingMessage.Replace("{OwnerName}", setting.OwnerName);
        }
        public string Talk()
        {
            return Mesg;
        }

        internal void Configure(Action<Setting> p)
        {
            p.Invoke(_p);
            SetMessage(_p);
            //
        }
        //public Action<Setting> Configure = s => SetMessage(s);



    }
}
