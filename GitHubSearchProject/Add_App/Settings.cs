using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GitHubSearchProject.Add_App
{
    public class Settings
    {
        public const string Url = "https://api.github.com/search/repositories?q=";
        public const string Accept = @"text/html,application/xhtml+xml,application/xml;q=0.9,image/webp,image/apng," +
            @"*/*;q=0.8,application/signed-exchange;v=b3;q=0.9";
        public const string AcceptLanguageKey = "Accept-Language";
        public const string AcceptLanguageValue = "ru,en-GB;q=0.9,en;q=0.8,en-US;q=0.7";
        public const string UserAgent = @"Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36" +
            @" (KHTML, like Gecko) Chrome/92.0.4515.159 Safari/537.36 Edg/92.0.902.78";
    }
}
