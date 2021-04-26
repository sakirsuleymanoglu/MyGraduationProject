﻿using Core.Utilities.Results;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface ICategoryService
    {
        IDataResult<List<Category>> GetAll();
        IDataResult<List<Category>> GetTopFive();
        IDataResult<Category> GetById(int id);
        IResult Add(Category category);
        IResult Delete(Category category);
        IResult Update(Category category);
        IResult Deactivate(Category category);
        IResult Activate(Category category);
    }
}
