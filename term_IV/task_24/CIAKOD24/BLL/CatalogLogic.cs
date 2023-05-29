#pragma warning disable SYSLIB0011
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CIAKOD24_inner;
using CIAKOD24_exception;
using System.Runtime.Serialization.Formatters.Binary;

namespace CIAKOD24
{
    [Serializable]
    public class CatalogLogic : ICatalogLogic
    {
        private ICatalog catalog;

        public ICatalog Catalog { get => catalog; set => catalog = value; }

        public CatalogLogic()
        {
            catalog = new Catalog();
        }
        public CatalogLogic(ICatalog catalog)
        {
            Catalog = catalog;
        }

        public override string ToString()
        {
            return catalog.ToString();
        }

        public string ShowDisk(string nameDisk) 
        {
            return catalog.ShowDisk(nameDisk);
        }

        public string ShowCatalog()
        {
            return catalog.ShowCatalog();
        }

        public void DeleteDisk(string nameDisk)
        {
            catalog.DeleteDisk(nameDisk);
        }

        public void DeleteSong(string nameDisk, string nameSong, string nameSinger)
        {
            catalog.DeleteSong(nameDisk, nameSong, nameSinger);
        }

        public void AddSong(string nameDisk, string nameSong, string nameSinger)
        {
            catalog.AddSong(nameDisk, nameSong, nameSinger);
        }

        public void AddDisk(string nameDisk)
        {
            catalog.AddDisk(nameDisk);
        }

        public void SortBySongs()
        {
            catalog.SortBySongs();
        }
        public void SortBySingers()
        {
            catalog.SortBySingers();
        }

        public string SearchSongs(string nameSinger)
        {
            return catalog.SearchSongs(nameSinger);
        }

        public void Save(string path)
        {
            catalog.Save(path);
        }
    }
}
