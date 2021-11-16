using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton
{
    class Users
    {
         List<string> users = new List<string>(3);


        public Users()
        {
            AddToList("Elad");
            AddToList("ShemTov");
            AddToList("Gal");
            ShowList();
        }
        void ShowList()
        {
            foreach (var item in users)
            {
                Console.WriteLine(item);
            }
        }

        void AddToList(string name)
        {
            users.Add(name);
        }
        void UseWashingMachine()
        {
            if (Washingmachine.Instance.ChecAvailabilty())
            {
                Washingmachine.Instance.Wash();
            }
        }
        void checkWhoUse()
        {
            if (!Washingmachine.Instance.isReady)
            {
                Console.WriteLine("first member of list using washing machine");
            }
            else if (!Washingmachine.Instance.isFinished)
            {
                Console.WriteLine($"{users[2]} is using the machine");
            }
        }
        public override string ToString()
        {
            return $"waiting to wash cloths {users[1]}, {users[2]}, {users[3]}";
        }
    }
}
