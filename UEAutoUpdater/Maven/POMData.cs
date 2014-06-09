using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UEAutoUpdater.Maven
{
    class POMData
    {
        public string groupId { get; set; }
        public string name { get; set; }
        public string version { get; set; }
        public string classifier { get; set; }

        public POMData(string groupId, string name, string version, string classifier)
        {

        }
        
    }
}
