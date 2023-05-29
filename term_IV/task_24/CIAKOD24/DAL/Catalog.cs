#pragma warning disable SYSLIB0011
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CIAKOD24_exception;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Runtime.CompilerServices;
using CIAKOD24_inner;

namespace CIAKOD24
{
    [Serializable]
    public class Catalog : ICatalog
    {
        private List<Disk> catalog;

        internal Catalog() 
        {
            catalog = new List<Disk>();
        }

        internal Catalog(string path)
        {
            using (FileStream fs = new FileStream(path, FileMode.OpenOrCreate))
            {
                BinaryFormatter formatter = new BinaryFormatter();
                catalog = (List<Disk>)formatter.Deserialize(fs);
            }
        }

        public override string ToString()
        {
            string s = "";
            foreach (Disk disk in catalog)
            {
                s += disk.ToString();
                s += "\n";
            }
            s = s.TrimEnd('\n');
            return s;
        }

        internal Disk Search(string nameDisk)
        {
            if (nameDisk == "")
            {
                throw new Exception("Имя диска пусто");
            }

            Disk tmp = catalog.Find(x => x.Name == nameDisk);

            if (tmp == null)
            {
                throw new WrongValueException("Диск с таким именем не найден");
            }

            return tmp;
        }

        public string ShowDisk(string nameDisk) 
        {
            Disk tmp = Search(nameDisk);
            if (tmp != null)
                return tmp.ToString();
            return "";
        }

        public string ShowCatalog()
        {
            return ToString() + "\n";
        }

        public void DeleteDisk(string nameDisk)
        {
            Disk tmp = Search(nameDisk);
            if (tmp != null)
            {
                catalog.Remove(tmp);
            }
        }

        public void DeleteSong(string nameDisk, string nameSong, string nameSinger)
        {
            Disk tmp = Search(nameDisk);
            if (tmp != null)
            {
                int ind = tmp.playlist.FindIndex(x => x.Song.Name == nameSong && x.Name == nameSinger);

                
                if (ind == -1)
                     throw new WrongValueException("Песня не найдена");

                tmp.playlist.RemoveAt(ind);
            }
        }

        public void AddSong(string nameDisk, string nameSong, string nameSinger)
        {
            Disk tmp = Search(nameDisk);
            if (tmp != null)
            {
                Singer tmpSinger = new Singer(nameSinger, nameSong);
                Singer same = tmp.playlist.Find(x => Singer.Equals(x, tmpSinger));
                if (same != null)
                {
                    throw new WrongValueException("Песня с таким именем уже есть на диске");
                }

                if (same == null)
                {
                    tmp.playlist.Add(tmpSinger);
                }
            }
        }

        public void AddDisk(string nameDisk)
        {
            if (nameDisk == "")
            {
                throw new Exception("Имя диска пусто");
            }

            if (catalog.Find(x => x.Name == nameDisk) != null)
            {
                throw new WrongValueException("Диск с таким именем не существует");
            }

            catalog.Add(new Disk(nameDisk));
        }

        public void SortBySongs()
        {
            foreach(Disk disk in catalog)
            {
                disk.playlist.Sort(Singer.CompBySongs);
            }
        }
        public void SortBySingers()
        {
            foreach (Disk disk in catalog)
            {
                disk.playlist.Sort(Singer.CompBySingers);
            }
        }

        public string SearchSongs(string nameSinger)
        {
            bool found = false;
            string res = "";

            res = res + $"Песни исполнителя {nameSinger}: \n";
            foreach (Disk disk in catalog)
            {
                foreach (Singer singer in disk.playlist)
                {
                    if (singer.Name == nameSinger)
                    {
                        res = res + "\t" + disk.Name + ": \t" + singer.ToString() + "\n";
                        found = true;
                    }
                }
            }
            if (!found)
            {
                throw new Exception("Песни не найдены");
            }

            return res;
        }

        public void Save(string path)
        {
            BinaryFormatter formatter = new BinaryFormatter();
            using (FileStream fs = new FileStream(path, FileMode.OpenOrCreate))
            {
                formatter.Serialize(fs, catalog);
            }
        }
    }
}
