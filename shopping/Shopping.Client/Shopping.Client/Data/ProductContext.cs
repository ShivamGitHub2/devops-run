using Shopping.Client.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace Shopping.Client.Data
{
    public static class ProductContext
    {

        public static readonly List<product> product = new List<product>
        {
            new product()
            {
                Name="Iphone",
                Description="this is iphone",
                ImageFile="product-1.png",
                Price = 30.00M,
                Category="smart phone"

            },
            new product()
            {
                Name="Samsung",
                Description="this is Samsung",
                ImageFile="product-2.png",
                Price = 40.00M,
                Category="smart Tab"

            }
        };
    }
}
