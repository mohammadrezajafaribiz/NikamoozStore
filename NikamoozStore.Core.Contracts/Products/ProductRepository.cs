﻿using NikamoozStore.Core.Domain.Products;
using System;
using System.Collections.Generic;
using System.Text;

namespace NikamoozStore.Core.Contracts.Products
{
    public interface ProductRepository
    {
        int TotalCount();
        List<Product> GetProducts(int pageSize = 4, int pageNumber = 1); 
    }
}