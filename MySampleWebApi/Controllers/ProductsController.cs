using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MySampleWebApi.Resources;

namespace MySampleWebApi.Controllers
{

    /// <summary>
    /// 商品の検索・変更用APIコントローラ。
    /// </summary>
    [Produces("application/json", Type = typeof(Product))]
    [Route("api/[controller]")]
    public class ProductsController : Controller
    {

        private static Product[] products = new Product[] {
                new Product() { id = 100, ProdCd = "AAA", ProdName = "商品 A", Price = 123.45m, CreatedAt = DateTime.Now },
                new Product() { id = 101, ProdCd = "BBBB", ProdName = "商品 B", Price = 98.99m, CreatedAt = DateTime.Now },
                new Product() { id = 102, ProdCd = "CCCC", ProdName = "商品 C", Price = 12.0m, CreatedAt = DateTime.Now },
                new Product() { id = 103, ProdCd = "DDDDD", ProdName = "商品 D", Price = 3.45m, CreatedAt = DateTime.Now },
        };


        /// <summary>
        /// 商品の一覧を返す。
        /// </summary>
        /// <returns></returns>
        // GET api/products
        [HttpGet]
        public IEnumerable<Product> Get()
        {
            return products;
        }

        /// <summary>
        /// 指定されたIdを持つ商品を返す。
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        // GET api/products/5
        [HttpGet("{id:long}")]
        public IActionResult Get(long id)
        {
            var product = products.FirstOrDefault(p => p.id == id);
            if (product == null) {
                return NotFound();
            }
            return Ok(product);
        }

        /// <summary>
        /// 商品を新規登録する。
        /// </summary>
        /// <param name="product"></param>
        // POST api/products
        [HttpPost]
        public void Post([FromBody]Product product)
        {
        }

        /// <summary>
        /// 商品を更新する。
        /// </summary>
        /// <param name="id"></param>
        /// <param name="product"></param>
        // PUT api/products/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody]Product product)
        {
        }

        /// <summary>
        /// 商品を削除する。
        /// </summary>
        /// <param name="id"></param>
        // DELETE api/products/5
        [HttpDelete("{id}")]
        public void Delete(long id)
        {
        }
    }
}
