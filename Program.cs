using System;
using System.Collections.Generic;
using System.Text;


namespace RPPOON_LV5
{
    class Program
    {
        static void Main(string[] args)
        {
            //Box MayBox = new Box("MyBox");
            //MayBox.Add(new Product("Rolex watch", 300, 3.7));
            //MayBox.Add(new Product("Pc graphics card", 50, 2.6));
            //Console.WriteLine(MayBox.Description());
            //Console.WriteLine("Price:" +MayBox.Price);
            //Console.WriteLine("Weight:" + MayBox.Weight);

            
            //ShippingService Shipper = new ShippingService(3);
            //Console.WriteLine(Shipper.ToString() + Shipper.Price(MayBox) + " $"); 

            //Dataset Data = new Dataset("TestdataCSV.txt");
            //User Me = User.GenerateUser("Stjepan");
            //ProtectionProxyDataset Myproxy = new ProtectionProxyDataset(Me);
            //VirtualProxyDataset Dataproxy = new VirtualProxyDataset("TestdataCSV.txt");
            //DataConsolePrinter printer = new DataConsolePrinter();
            //printer.Print(Myproxy);
            //Console.WriteLine();
            //printer.Print(Dataproxy);

            ITheme theme1 = new LightTheme();
            ITheme theme2 = new DarkTheme();
            ReminderNote note1 = new ReminderNote("RPPOON LV5 starts at 8.00 am", theme1);
            GroupNote note2 = new GroupNote("Students for Lv", theme2);
            note2.InsertMember("Stjepan Prakljačić");
            note2.InsertMember("Student 21");
            note2.Show();
            Notebook notes = new Notebook(theme1);
            notes.AddNote(note1);
            notes.Display();
        } 
    }
}
