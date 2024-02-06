﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Identity.Services;

public class RedirectService : IRedirectService
{
    public string ExtractRedirectUriFromReturnUrl(string url)
    {
        var decodedUrl = System.Net.WebUtility.HtmlDecode(url);
        var results = Regex.Split(decodedUrl, "redirect_uri=");
        if (results.Length < 2)
            return "";

        string result = results[1];

        string splitKey;
        if (result.Contains("signin-oidc"))
            splitKey = "signin-oidc";
        else
            splitKey = "scope";

        results = Regex.Split(result, splitKey);
        if (results.Length < 2)
            return "";

        result = results[0];

        return result.Replace("%3A", ":").Replace("%2F", "/").Replace("&", "");
    }
}