using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UEAutoUpdater.Maven;

namespace UEAutoUpdater
{
    class UEAutoUpdater
    {
        // Required Args! maven repo name download! invoke from modstats. use ; to separate.
        // Example: Resonant-Engine-Development;ICBM-Development;Resonant-Induction-Development (as args)
        static void Main(string[] args)
        {
            if (args.Length < 2)
                throw new ArgumentException("Must have atleast 2 args! repo's and url!");

            Console.WriteLine("UE-Auto-Updater Invoked, Grabbing files from maven server now.");
            IList<string> filesToGrab = (IList<string>) new List<string>(args[0].Split(';'));
            for (int i = 0; i < filesToGrab.Count(); i++)
            {
                Console.WriteLine(filesToGrab[i]);
            }
            Console.ReadKey();

            MavenHandler mavenHandler = new MavenHandler(filesToGrab, args[1]);

        }
    }
}
