using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CIAKOD24
{
    public interface ICatalogLogic
    {
        string ShowDisk(string nameDisk);
        string ShowCatalog();
        void DeleteDisk(string nameDisk);
        void DeleteSong(string nameDisk, string nameSong, string nameSinger); 
        void AddSong(string nameDisk, string nameSong, string nameSinger);
        void AddDisk(string nameDisk);
        void SortBySongs();
        void SortBySingers();
        string SearchSongs(string nameSinger);
        void Save(string path);
    }
}
