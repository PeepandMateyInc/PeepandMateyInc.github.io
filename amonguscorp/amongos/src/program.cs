using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace AmongOS
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Among OS Bootup Shell \nCopyright (C) 2021 AmongUs Corporation. All rights reserved.");
            Thread.Sleep(5000);
            Console.Clear();

            Console.WriteLine("Among OS Bootup Shell \nCopyright (C) 2021 AmongUs Corporation. All rights reserved.\n");
            Console.WriteLine("Unzipping Files... \n0.00kb/1000.00mb \n0mb/s \n-----");
            Thread.Sleep(1000);
            Console.Clear();
            Console.WriteLine("Among OS Bootup Shell \nCopyright (C) 2021 AmongUs Corporation. All rights reserved.\n");
            Console.WriteLine("Unzipping Files... \n500.00mb/1000.00mb \n500mb/s \n|----");
            Thread.Sleep(1000);
            Console.Clear();
            Console.WriteLine("Among OS Bootup Shell \nCopyright (C) 2021 AmongUs Corporation. All rights reserved.\n");
            Console.WriteLine("Unzipping Files... \n1000.00mb/1000.00mb \n500mb/s \n||---");
            Thread.Sleep(1000);
            Console.Clear();
            Console.WriteLine("Among OS Bootup Shell \nCopyright (C) 2021 AmongUs Corporation. All rights reserved.\n");
            Console.WriteLine("Packaging Files... \n|||--");
            Thread.Sleep(2000);
            Console.Clear();
            Console.WriteLine("Among OS Bootup Shell \nCopyright (C) 2021 AmongUs Corporation. All rights reserved.\n");
            Console.WriteLine("Reading Files... \n||||-");
            Thread.Sleep(1500);
            Console.Clear();
            Console.WriteLine("Among OS Bootup Shell \nCopyright (C) 2021 AmongUs Corporation. All rights reserved.\n");
            Console.WriteLine("Booting... \n|||||");
            Thread.Sleep(1000);
            Console.Clear();

            Boot(20);

            // -----------------------------------------------------------------

            Console.WriteLine("Error: [Undefined]");
            Console.WriteLine("Restarting...");
            Thread.Sleep(5000);

            Console.Clear();

            Load(10);

            Console.Clear();

            Console.WriteLine("Among OS Bootup Shell \nCopyright (C) 2021 AmongUs Corporation. All rights reserved.\n");
            Console.WriteLine("System Restarted");

            Console.Clear();

            Console.WriteLine("Among OS Bootup Shell \nCopyright (C) 2021 AmongUs Corporation. All rights reserved.\n");
            Console.WriteLine("System Requirements: Not Met \nAmong Sus 7 CPU: X \nAmong Sus 7 GPU: X \n10PB of Amog Sus RAM: X \nAmong Sus Secure Boot: X");
            Console.WriteLine("Your system does not meet the minimum requirements. Shutting Down...");
            Thread.Sleep(5000);
            System.Environment.Exit(0);
        }

        public static void Boot(int num)
        {
            Random rnd = new Random();
            int randomNum = rnd.Next(num);
            for (int i = 0; i <= randomNum; i++)
            {
                Console.WriteLine("Among OS Bootup Shell \nCopyright (C) 2021 AmongUs Corporation. All rights reserved.\n");
                Console.WriteLine(" - Among OS Booting");
                Thread.Sleep(0500);
                Console.Clear();
                Console.WriteLine("Among OS Bootup Shell \nCopyright (C) 2021 AmongUs Corporation. All rights reserved.\n");
                Console.WriteLine(" / Among OS Booting");
                Thread.Sleep(0500);
                Console.Clear();
                Console.WriteLine("Among OS Bootup Shell \nCopyright (C) 2021 AmongUs Corporation. All rights reserved.\n");
                Console.WriteLine(" | Among OS Booting");
                Thread.Sleep(0500);
                Console.Clear();
                Console.WriteLine("Among OS Bootup Shell \nCopyright (C) 2021 AmongUs Corporation. All rights reserved.\n");
                Console.WriteLine(" \\ Among OS Booting");
                Thread.Sleep(0500);
                Console.Clear();
            }
            string space = " ";
            Console.WriteLine("Among OS Bootup Shell \nCopyright (C) 2021 AmongUs Corporation. All rights reserved.\n");
            Console.WriteLine(" - Among OS Beta Booted \n");
            Console.WriteLine(space + space + space + space + space + space + space + space + space + space + "...........");
            Console.WriteLine(space + space + space + space + space + space + space + space + space + "................");
            Console.WriteLine(space + space + space + space + space + space + space + space + "..." + space + space + space + space + space + space + space + "........");
            Console.WriteLine(space + space + space + space + space + space + space + "..." + space + space + space + space + space + "............");
            Console.WriteLine(space + space + space + space + space + space + space + "..." + space + space + space + space + "..." + space + space + space + space + space + space + space + space + space + "...");
            Console.WriteLine(space + space + "......." + space + space + space + space + "..." + space + space + space + space + space + space + space + space + space + space + space + "..");
            Console.WriteLine(space + "..." + space + space + "..." + space + space + space + space + "...." + space + space + space + space + space + space + space + space + space + "...");
            Console.WriteLine(space + ".." + space + space + space + "..." + space + space + space + space + space + "..............");
            Console.WriteLine(space + ".." + space + space + space + "..." + space + space + space + space + space + space + "............");
            Console.WriteLine(space + "..." + space + space + "..." + space + space + space + space + space + space + space + space + space + space + space + space + space + space + space + space + "...");
            Console.WriteLine(space + space + "......." + space + space + space + space + space + "......." + space + space + space + "...");
            Console.WriteLine(space + space + space + space + space + space + space + ".." + space + space + space + space + space + "..." + space + "..." + space + space + space + "...");
            Console.WriteLine(space + space + space + space + space + space + space + ".." + space + space + space + space + space + "..." + space + "..." + space + space + space + "...");
            Console.WriteLine(space + space + space + space + space + space + space + ".........." + space + space + ".......");
            Console.WriteLine(space + space + space + space + space + space + space + space + "........\n");
        }

        public static void Load(int num)
        {
            Random rnd = new Random();
            int randomNum = rnd.Next(num);
            for (int i = 0; i <= randomNum; i++)
            {
                Console.WriteLine("Among OS Bootup Shell \nCopyright (C) 2021 AmongUs Corporation. All rights reserved.\n");
                Console.WriteLine(
                    "\n."
                );
                Thread.Sleep(500);
                Console.Clear();

                Console.WriteLine("Among OS Bootup Shell \nCopyright (C) 2021 AmongUs Corporation. All rights reserved.\n");
                Console.WriteLine(
                    "  .\n" +
                    "."
                );
                Thread.Sleep(500);
                Console.Clear();

                Console.WriteLine("Among OS Bootup Shell \nCopyright (C) 2021 AmongUs Corporation. All rights reserved.\n");
                Console.WriteLine(
                    "  .\n" +
                    ".   ."
                );
                Thread.Sleep(500);
                Console.Clear();

                Console.WriteLine("Among OS Bootup Shell \nCopyright (C) 2021 AmongUs Corporation. All rights reserved.\n");
                Console.WriteLine(
                    "  .\n" +
                    ".   ." +
                    "\n  .  "
                );
                Thread.Sleep(500);
                Console.Clear();
            }
        }
    }
}
