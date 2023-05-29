using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CIAKOD24_inner;
using CIAKOD24_exception;

namespace CIAKOD24
{
    public static class DependencyResolver
    {
        static private ICatalog catalog;
        static private ICatalogLogic catalogLogic;

        static public ICatalog Catalog
        {
            get => catalog ?? (catalog = new Catalog());
            set => catalog = value;
        }
        static public ICatalogLogic CatalogLogic
        {
            get => catalogLogic ?? (catalogLogic = new CatalogLogic(Catalog));
            set => catalogLogic = value;
        }

        static public ICatalogLogic OpenFile(string path)
        {
            Catalog = new Catalog(path);
            CatalogLogic = new CatalogLogic(Catalog);
            return CatalogLogic;
        }

        static public ICatalogLogic CreateFile()
        {
            Catalog = new Catalog();
            CatalogLogic = new CatalogLogic(Catalog);
            return CatalogLogic;
        }
    }
}