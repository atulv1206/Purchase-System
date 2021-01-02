using PurchageSystem.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PurchageSystem.DTO
{
    public class ProductMstDTO
    {
        public List<ProductTypeMst> ProductTypeMstList { get; set; }
        public ProductMst productMst { get; set; }
    }
}