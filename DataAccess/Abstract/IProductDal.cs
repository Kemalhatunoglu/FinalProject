﻿using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Abstract
{
    // Interface methodları default olarak public olarak tanımlıdır.
    public interface IProductDal:IEntityRepository<Product>
    {
     
    }
}
