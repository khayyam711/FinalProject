﻿using System;
using System.Collections.Generic;
using System.Text;
using Entities.Concrete;

namespace Business.Abstract
{
    public interface IProductService
    {
        List<Product> GetALL();
        List<Product> GetAllByCategoryId(int id);

        List<Product>GetByUnitPrice(decimal min, decimal max);
    }
}
