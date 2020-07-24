using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

using WingtipToys.Models;

namespace WingtipToys.Logic
{
    public class AdminOperation
    {
        public void ChangeSoldNumber(int id, int number)

        {
            using (ProductContext _db = new ProductContext())
            {
                var product = (from c in _db.Products where c.ProductID == id select c).FirstOrDefault();
                //书本加入数据库
                product.Sold += number;
                _db.SaveChanges();

            }

        }

        public List<Product> GetAllProduct()
        {
            ProductContext _db = new ProductContext();
            return _db.Products.ToList();
        }
    }
}