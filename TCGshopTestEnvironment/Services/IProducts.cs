﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TCGshopTestEnvironment.Models;
using TCGshopTestEnvironment.ViewModels;

namespace TCGshopTestEnvironment.Services
{
    //all possible methods for gaining/writing data to the products table in the database
    public interface IProducts
    {
        Products GetByID(int id);
        void Add(Products NewProduct);

        IEnumerable<Productsandcategorie> GetbyCardType(string type);

        IEnumerable<Productsandcategorie> GetByNameSearch(string name);

        IEnumerable<PopularViewModel> GetMostViewed();

    }
}
