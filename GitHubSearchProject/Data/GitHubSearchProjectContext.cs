using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using GitHubSearchProject.Models;

namespace GitHubSearchProject.Data
{
    public class GitHubSearchProjectContext : DbContext
    {
        public GitHubSearchProjectContext (DbContextOptions<GitHubSearchProjectContext> options)
            : base(options)
        {
        }

        public DbSet<GitHubSearchProject.Models.SearchQuery> SearchQuery { get; set; }
    }
}
