using System.Collections.Generic;
using T2_HoangNam.Models;

namespace T2_HoangNam.Models
{
    public interface IProductRepository
    {
        IEnumerable<Product> GetAll();
        Product GetById(int id);
        void Add(Product product);
        void Update(Product product);
        void Delete(int id);
    }
}
