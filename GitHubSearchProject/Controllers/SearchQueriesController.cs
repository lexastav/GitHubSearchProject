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

            if (!string.IsNullOrEmpty(searchString))
            {
                searchQueries = searchQueries.Where(s => s.Query.Contains(searchString));

                if (searchQueries.Count() == 0)
                {
                    _context.SearchQuery.AddRange(
                    new SearchQuery
                    {
                        Query = searchString,
                        Data = GetData.Get(searchString),
                    });
                    _context.SaveChanges();
                }

            }
            return View(await searchQueries.ToListAsync());
        }
    }
}

       