using Microsoft.EntityFrameworkCore;
using PantryPal.Server.Models;

namespace PantryPal.Server.Data;

public class PantryPalContext : DbContext
{
    public PantryPalContext(DbContextOptions<PantryPalContext> options)
        : base(options)
    {

    }

    public DbSet<FoodItem> FoodItems { get; set; }
}
