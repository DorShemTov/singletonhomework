using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton
{
    class Washingmachine
    {
        public bool isReady = true;
        public bool isFinished = false;

        private static Washingmachine instance = null;

        public static Washingmachine Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new Washingmachine();
                }
                return instance;
            }
        }
        private Washingmachine()
        {

        }

        public void Wash()
        {
            isReady = false;
            
        }
        public bool ChecAvailabilty()
        {
            if (isReady == true)
            {
                isFinished = true;
                Console.WriteLine("I AM READY TO USE");
                return true;
            }
            else
            {
                Console.WriteLine("I am working");
                return false;
            }
        }


    }
}
