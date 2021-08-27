using GitHubProjectsSearch.ExternalData;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GitHubProjectsSearch.Models
{
    public class DataViewModel
    {
        public string SearchString { get; set; }
        public Dictionary<string, JsonData> Data { get; set; }
    }
}
