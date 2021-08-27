using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GitHubSearchProject.Models
{
    public class SearchQuery
    {
        public int Id { get; set; }
        public string Query { get; set; }
        public string Data { get; set; }
    }
}
