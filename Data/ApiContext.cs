using Microsoft.EntityFrameworkCore;
using CardDetailsAPI.Models;

namespace CardDetailsAPI.Data
{
    public class ApiContext : DbContext
    {
        public DbSet<CardDetails> CardDetails { get; set; }
        public ApiContext(DbContextOptions<ApiContext> options) : base(options)
        {

        }
    }
}
