using Microsoft.EntityFrameworkCore;
using System.Diagnostics.CodeAnalysis;
namespace CountryAPI.Models
{
    public class CountryContex : DbContext
    {
        public CountryContex(DbContextOptions<CountryContex> options)
            : base(options) 
        { 
        }

        public DbSet<CountryItem> CountryItems { get; set; } = null!;
    }
}
