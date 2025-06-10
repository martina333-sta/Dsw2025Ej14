using Dsw2025Ej14.Api.Domain;
using System.Text.Json;

namespace Dsw2025Ej14.Api.Data
{

    public class PersistenciaEnMemoria
    {
        private List<Product> _productos;

        public PersistenciaEnMemoria()
        {
            _productos = new List<Product>();
            LoadProducts();
        }

        private void LoadProducts()
        {
            var json = File.ReadAllText("Data\\products.json");
            _productos = JsonSerializer.Deserialize<List<Product>>(json, new JsonSerializerOptions
            {
                PropertyNameCaseInsensitive = true,
            }) ?? [];
            
        }

      public  Product GetProduct(string sku)
       {
            throw new NotImplementedException();
       }

        public IEnumerable<Product> GetProducts()
        {
            return _productos.Where(p => p.IsActive);
        }
    }
}
