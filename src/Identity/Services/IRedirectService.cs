﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Identity.Services;

public interface IRedirectService
{
    string ExtractRedirectUriFromReturnUrl(string url);
}