﻿using Domain.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities.Catalog;

public class Category : BaseEntity
{
    public string Name { get; set; }

    public string ImagePath { get; set; }
}
