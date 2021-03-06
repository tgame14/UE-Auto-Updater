﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using UEAutoUpdater.Maven;

namespace UEAutoUpdater
{
    class UEAutoUpdater
    {
        // Required Args! maven repo name download! invoke from modstats. use ; to separate.
        // Example: Resonant-Engine-Development;ICBM-Development;Resonant-Induction-Development (as args)
        // Also required a 3rd field! the path to mods folder
        // Example Invokation: UEAutoUpdater.cs Resonant-Induction; http://calclavia.com/maven C:/mods
        static void Main(string[] args)
        {
            if (args.Length < 2)
                throw new ArgumentException("Must have atleast 2 args! repo's and url!");

            Console.WriteLine("UE-Auto-Updater Invoked, Grabbing files from maven server now.");
            IList<string> filesToGrab = (IList<string>) new List<string>(args[0].Split(';'));
            Console.WriteLine("Accepted mods to auto-update. Deleting old files and redownloading");
            for (int i = 0; i < filesToGrab.Count(); i++)
            {
                Console.WriteLine(filesToGrab[i]);
            }
            
            Console.WriteLine("Downloading Files, Executing Secondary thread to delete and download files:");
            
            FileManager manager = new FileManager();
            Thread oThread = new Thread(new ThreadStart(manager.ThreadStart));

            oThread.Start();

            while (!oThread.IsAlive)
            {
                Console.Write('.');
            }

            Thread.Sleep(1);

            Console.ReadKey();
        }
    }
}
