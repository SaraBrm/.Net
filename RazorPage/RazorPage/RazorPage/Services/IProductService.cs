﻿using System.Collections.Generic;

namespace RazorPage.Services
{
    public interface IProductService
    {
        int Add(ProductDto product);
        int Delete(int Id);
        ProductDto Find(int Id);
        List<ProductDto> List();
        ProductDto Edit(ProductDto product);
        List<ProductDto> Search(string name);

    }
}
