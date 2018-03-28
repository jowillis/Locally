using LocallyDotCom.Clients;
using LocallyDotCom.Http;

namespace LocallyDotCom
{
    public class LocallyDotComClient
    {
        public LocallyDotComClient(string apiKey)
        {
            var connection = new ApiConnection(apiKey);
            Brands = new BrandsClient(connection);
            Catalog = new CatalogClient(connection);
            Categories = new CategoriesClient(connection);
        }

        public BrandsClient Brands { get; }

        public CatalogClient Catalog { get; }

        public CategoriesClient Categories { get; }
    }
}
