using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CIAKOD24_inner;
using CIAKOD24_exception;

namespace CIAKOD24
{
    internal class BaseCatalog
    {
        Catalog catalog;

        internal BaseCatalog()
        {
            catalog = new Catalog();
        }
        internal BaseCatalog(string path)
        {
            catalog = new Catalog(path);
        }

        public override string ToString()
        {
            return catalog.ToString();
        }
        internal string NameDisk()
        {
            Data.PrintToConsole("Name of disk: ");
            string nameDisk = Data.ReadFromConsole();
            return nameDisk;
        }

        private string NameSong()
        {
            Data.PrintToConsole("Name of song: ");
            string nameSong = Data.ReadFromConsole();
            return nameSong;
        }
        private string NameSinger()
        {
            Data.PrintToConsole("Name of singer: ");
            string nameSinger = Data.ReadFromConsole();
            return nameSinger;
        }

        internal Disk Search()
        {
            string nameDisk = NameDisk();
            Disk tmp = catalog.Search(nameDisk);
            return tmp;
        }

        internal void ShowDisk() 
        {
            string nameDisk = NameDisk();
            catalog.ShowDisk(nameDisk);
        }

        internal void ShowCatalog()
        {
            catalog.ShowCatalog();
        }

        internal void DeleteDisk()
        {
            string nameDisk = NameDisk();
            catalog.DeleteDisk(nameDisk);
        }

        internal void DeleteSong()
        {
            string nameDisk = NameDisk();
            string nameSong = NameSong();
            catalog.DeleteSong(nameDisk, nameSong);
        }

        internal void AddSong()
        {
            string nameDisk = NameDisk();
            string nameSong = NameSong();
            string nameSinger = NameSinger();
            catalog.AddSong(nameDisk, nameSong, nameSinger);
        }

        internal void AddDisk()
        {
            string nameDisk = NameDisk();
            catalog.AddDisk(nameDisk);
        }

        internal void SortBySongs()
        {
            catalog.SortBySongs();
        }
        internal void SortBySingers()
        {
            catalog.SortBySingers();
        }

        internal void SearchSongs()
        {
            string nameSinger = NameSinger();
            catalog.SearchSongs(nameSinger);
        }

        internal void Save()
        {
            Data.PrintToConsole("Enter path of file to save: ");
            string path = Data.ReadFromConsole();
            catalog.Save(path);
        }
    }
}
