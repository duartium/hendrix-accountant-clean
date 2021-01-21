﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HendrixAccountant.ApplicationCore.CacheKeys
{
    public class ProductCacheKeys
    {
        public static string ListKey => "ProductList";

        public static string SelectListKey => "ProductSelectList";

        public static string GetKey(int productId) => $"Product-{productId}";

        public static string GetDetailsKey(int productId) => $"ProductDetails-{productId}";
    }
}
