using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using CIAKOD24_exception;
using CIAKOD24_inner;

namespace CIAKOD24
{
    [Serializable]
    internal class Disk
    {
        private string name;
        internal List<Singer> playlist;
        internal string Name
        {
            get { return name; }
        }
        internal Disk()
        {
            name = "";
            playlist = new List<Singer>();
        }
        internal Disk(string name)
        {
            this.name = name;
            playlist = new List<Singer>();
        }
        public override string ToString()
        {
            string s = $"{Name}:\n";
            foreach (Singer singer in playlist)
            {
                s += '\t';
                s += singer.ToString();
                s += '\n';
            }
            return s;
        }
    }
}
