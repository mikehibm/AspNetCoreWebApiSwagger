using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MySampleWebApi.Resources
{
    public class Product
    {
        /// <summary>
        /// 商品のIdentity
        /// </summary>
        public long id { get; set; }

        /// <summary>
        /// 商品コード(カタログ上のコード)
        /// </summary>
        public string ProdCd { get; set; }

        /// <summary>
        /// 商品名称
        /// </summary>
        public string ProdName { get; set; }

        /// <summary>
        /// 現在の価格
        /// </summary>
        public decimal Price { get; set; }

        /// <summary>
        /// 登録日
        /// </summary>
        public DateTime CreatedAt { get; set; }

    }
}
