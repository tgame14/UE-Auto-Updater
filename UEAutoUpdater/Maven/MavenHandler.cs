using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UEAutoUpdater.Maven
{
    class MavenHandler
    {
        private POMData repoData;
        private string repo;
        

        public MavenHandler(POMData mavenData, string repo)
        {
            this.repoData = mavenData;
        }
    }
}
