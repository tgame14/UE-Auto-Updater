using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UEAutoUpdater.Maven
{
    class MavenHandler
    {
        public string repoUrl;
        private IList<string> reposToGrab;

        public MavenHandler(IList<string> mavenNamesToGrab, string repo)
        {
            this.reposToGrab = mavenNamesToGrab;
            this.repoUrl = repo;

        }
    }
}
