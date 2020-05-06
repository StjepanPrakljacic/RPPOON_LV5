using System;
using System.Collections.Generic;
using System.Text;

namespace RPPOON_LV5
{
    class DataConsolePrinter
    {
        public DataConsolePrinter() { }
        public void Print(IDataset data)
        {

            IReadOnlyCollection<List<string>> items = data.GetData();
            if (items == null)
            {
                Console.WriteLine("Empty");
                return;
            }
            foreach (List<string> Data in items)
            {
                foreach (string line in Data)
                {
                    Console.Write(line + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
