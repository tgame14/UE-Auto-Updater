using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.IO;

namespace UEAutoUpdater
{
    class FileManager
    {

        public void ThreadStart()
        {
            Console.WriteLine("FileManager thread is now Running");
            File.Delete("pathneeded");
        }

    }
}
