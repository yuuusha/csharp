using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CIAKOD24_inner
{
    [Serializable]
    internal class Song
    {
        private string name;

        internal string Name
        {
            get { return name; }
        }
        internal Song()
        {
            this.name = "";
        }
        internal Song(string name)
        {
            this.name = name;
        }
        public override string ToString()
        {
            return this.name;
        }
    }
}
