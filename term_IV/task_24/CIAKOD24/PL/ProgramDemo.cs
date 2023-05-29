#pragma warning disable SYSLIB0011
using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using CIAKOD24_exception;

namespace CIAKOD24
{
    class ProgramDemo
    {
        static void Main(string[] args)
        {
            ICatalogLogic catalog = DependencyResolver.CatalogLogic;
            catalog = DependencyResolver.OpenFile("catalogDemo.dat");
            //catalog = catalog.OpenFile("catalogDemo.dat");
            //catalog.ShowCatalog();
            //catalog.AddDisk("Disk C");
            //catalog.DeleteDisk("Disk A");
            //catalog.AddSong("Disk C", "Song8", "Singer9");
            //catalog.SortBySingers();
            //Data.PrintToConsole("");
            //catalog.SearchSongs("Singer5");
            //Data.PrintToConsole("");
            //catalog.ShowCatalog();
            //catalog.AddDisk("Disk A");
            //catalog.AddSong("Disk A", "А я девушек люблю", "Олег Газманов");
            //catalog.AddSong("Disk A", "Симфония #5", "Чайковский");
            //catalog.AddSong("Disk A", "Yellow Submarine", "The Beetles");
            //catalog.AddSong("Disk A", "Beat it", "Michael Jackson");
            //catalog.AddDisk("Disk B");
            //catalog.AddSong("Disk B", "Между нами тает лед", "Грибы");
            //catalog.AddSong("Disk B", "Начало весны", "Moriko");
            //catalog.AddSong("Disk A", "Pray for the Wicked Tour", "Panic! at the Dicso");
            //catalog.AddSong("Disk B", "XXX", "Олег Газманов");
            //catalog.AddSong("Disk A", "sndkgjdb", "klshgjksd");

            Console.WriteLine(catalog.ShowCatalog());

            // catalog.DeleteSong("Disk A", "Beat it", "Michael Jackson");

            // catalog.ShowCatalog();

            ////catalog.DeleteDisk("Disk B");

            // //catalog.ShowCatalog();

            //catalog.SearchSongs("Олег Газманов");

            // catalog.SortBySingers();

            // catalog.ShowCatalog();

            // catalog.SortBySongs();

            // catalog.ShowCatalog();

            catalog.Save("catalogDemo.dat");
            

        }

    }
}