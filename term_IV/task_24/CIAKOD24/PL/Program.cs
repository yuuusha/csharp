//#pragma warning disable SYSLIB0011
//using System;
//using System.Collections.Generic;
//using System.IO;
//using System.Text;
//using CIAKOD24_exception;

//namespace CIAKOD24
//{
//    class Program
//    {
//        static string NameDisk()
//        {
//            Data.PrintToConsole("Name of disk: ");
//            string nameDisk = Data.ReadFromConsole();
//            return nameDisk;
//        }

//        static string NameSong()
//        {
//            Data.PrintToConsole("Name of song: ");
//            string nameSong = Data.ReadFromConsole();
//            return nameSong;
//        }
//        static string NameSinger()
//        {
//            Data.PrintToConsole("Name of singer: ");
//            string nameSinger = Data.ReadFromConsole();
//            return nameSinger;
//        }
//        static void Menu()
//        {
//            Data.PrintToConsole($@"0. Exit without save
//1. Add new empty disk
//2. Delete disk
//3. Add new song
//4. Delete song
//5. Show current disk
//6. Search songs of singer in the catalog
//7. Sort songs by songs' name
//8. Sort songs by singers' name
//9. Save catalog
//10. Open new catalog
//");

//        }
//        static void Main(string[] args)
//        {
//            Data.Clear();
//            Data.PrintToConsole("Enter the path to open the catalog: ");
//            string path = Data.ReadFromConsole();

//            try
//            {
//                if (!File.Exists(path))
//                    throw new WrongValueException("File not found");
//                else
//                    Data.PrintToConsole("File load success\n");
//            }
//            catch(WrongValueException ex) { 
//                Data.PrintToConsole(ex.Message);
//                return;
//            }

//            ICatalogLogic catalog = DependencyResolver.CatalogLogic;
//            catalog = catalog.OpenFile(path);
//            bool shouldClose = false;

//            while (!shouldClose)
//            {
//                catalog.ShowCatalog();
//                Menu();
//                Data.PrintToConsole("Enter the action:");
//                int mode = 0;
//                bool first = true;

//                while (first)
//                {
//                    try
//                    {
//                        mode = int.Parse(Data.ReadFromConsole());
//                        if (mode > 11 || mode < 0) throw new WrongValueException("out of range");
//                    }
//                    catch (FormatException)
//                    {
//                        Data.PrintToConsole("Incorrect format: no such action");
//                        continue;
//                    }
//                    catch (WrongValueException ex)
//                    {
//                        Data.PrintToConsole("Incorrect format: " + ex.Message);
//                        continue;
//                    }
//                    first = false;
//                }

//                switch (mode) 
//                {

//                    case 0:
//                        return;

//                    case 1:
//                        string nameDisk = NameDisk();
//                        catalog.AddDisk(nameDisk);
//                        break;

//                    case 2:
//                        nameDisk = NameDisk();
//                        catalog.DeleteDisk(nameDisk);
//                        break;

//                    case 3:
//                        nameDisk = NameDisk();
//                        string nameSong = NameSong();
//                        string nameSinger = NameSinger();
//                        catalog.AddSong(nameDisk, nameSong, nameSinger);
//                        break;

//                    case 4:
//                        nameDisk = NameDisk();
//                        nameSong = NameSong();
//                        nameSinger = NameSinger();
//                        catalog.DeleteSong(nameDisk, nameSong, nameSinger);
//                        break;

//                    case 5:
//                        nameDisk = NameDisk();
//                        catalog.ShowDisk(nameDisk);
//                        break;

//                    case 6:
//                        nameSinger = NameSinger();
//                        catalog.SearchSongs(nameSinger);
//                        break;

//                    case 7:
//                        catalog.SortBySongs();
//                        break;

//                    case 8:
//                        catalog.SortBySingers();
//                        break;

//                    case 9:
//                        Data.PrintToConsole("Enter path of file to save: ");
//                        path = Data.ReadFromConsole();

//                        if (path == "")
//                        {
//                            path = "StandartName.dat";
//                        }

//                        catalog.Save(path);
//                        break;

//                    case 10:
//                        Main(null);
//                        return;

//                }

//                Data.PrintToConsole("Press any key to continue...");
//                Data.ReadFromConsole();
//                Data.Clear();
//            }
//        }
//    }
//}