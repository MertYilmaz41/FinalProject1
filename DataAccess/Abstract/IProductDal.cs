﻿using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Abstract
{
    //Data Access Layer - DAL
    public interface IProductDal : IEntityRepository<Product>
    {

    }
}
