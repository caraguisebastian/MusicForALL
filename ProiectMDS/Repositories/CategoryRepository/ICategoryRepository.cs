﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MFA.Models;

namespace MFA.Repositories.CategoryRepository
{
    public interface ICategoryRepository
    {
        List<Category> GetAll();
        Category Get(int Id);
        Category Create(Category category);
        Category Update(Category category);
        Category Delete(Category category);
    }
}
