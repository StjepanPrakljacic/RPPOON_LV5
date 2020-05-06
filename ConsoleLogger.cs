using System;
using System.Collections.Generic;
using System.Text;

namespace RPPOON_LV5
{
    class ConsoleLogger
    {
        private static ConsoleLogger instance;

        public static ConsoleLogger GetInstance()
        {

            if (instance == null)
            {
                instance = new ConsoleLogger();
            }

            return instance;
        }

        public void Log(string data)
        {
            Console.WriteLine(data);
        }
    }
}
