using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q2_User_Class
{
    class User
    {
        static List<string> users = new List<string>();
        public void Add(string UserName)
        {
            users.Add(UserName);
        }
        public int GetUsersCount()
        {
            return users.Count;
        }
    }
}
