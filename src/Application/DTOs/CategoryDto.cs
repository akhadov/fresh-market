﻿using Application.DTOs.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.DTOs;

public class CategoryDto : BaseDto
{
    public string Name { get; set; }

    public string PictureId { get; set; }
}
