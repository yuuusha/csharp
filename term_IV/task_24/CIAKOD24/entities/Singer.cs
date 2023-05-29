using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace CIAKOD24_inner
{
    [Serializable]
    internal class Singer
    {
        private string name;
        private Song song;

        internal Song Song 
        { 
            get { return song; } 
        }
        internal string Name
        {
            get { return name; }
        }
        internal Singer()
        {
            this.name = "";
            this.song = new Song();
        }
        internal Singer(string name, string song)
        {
            this.name = name;
            this.song = new Song(song);
        }

        public override string ToString()
        {
            return $"{this.Name} - {song}";
        }

        internal static bool Equals(Singer left, Singer right)
        {
            return left.Name == right.Name && left.Song.Name == right.Song.Name;
        }

        internal static int CompBySingers(Singer A, Singer B)
        {
            if (A.Name != B.Name)
                return A.Name.CompareTo(B.Name);
            else
                return A.Song.Name.CompareTo(B.Song.Name);
        }
        internal static int CompBySongs(Singer A, Singer B)
        {
            if (A.Song.Name != B.Song.Name)
                return A.Song.Name.CompareTo(B.Song.Name);
            else
                return A.Name.CompareTo(B.Name);
        }
    }
}
