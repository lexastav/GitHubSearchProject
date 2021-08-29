using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using GitHubSearchProject.Data;
using GitHubSearchProject.Models;
using GitHubSearchProject.Add_App;
using System.Text.Json;
using GitHubProjectsSearch.ExternalData;
using GitHubProjectsSearch.Models;

namespace GitHubSearchProject.Controllers
{
    public class SearchQueriesController : Controller
    {
        private readonly GitHubSearchProjectContext _context;

        public SearchQueriesController(GitHubSearchProjectContext context)
        {
            _context = context;
        }

        // GET: SearchQueries
        public async Task<IActionResult> Index(string searchString)
        {
            var searchQueries = from s in _context.SearchQuery
                                select s;
            string data = "";
            var viewedData = new JsonData();
            if (!string.IsNullOrEmpty(searchString))
            {
                searchQueries = searchQueries.Where(s => s.Query.Contains(searchString));

                if (searchQueries.Count() == 0)
                {
                    data = GetterData.Get(searchString);
                    _context.SearchQuery.AddRange(
                    new SearchQuery
                    {
                        Query = searchString,
                        Data = data,
                    });
                    _context.SaveChanges();
                }

                //if (searchQueries.Count() > 0)
                //{
                //    viewedData = JsonSerializer.Deserialize<JsonData>(data);
                //}
            }
     
                return View(await searchQueries.ToArrayAsync());

            
        }
    }
}

       