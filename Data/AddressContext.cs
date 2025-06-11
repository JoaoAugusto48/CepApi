using Microsoft.EntityFrameworkCore;

namespace CepApi.Data;

public class AddressContext : DbContext
{
    public AddressContext(DbContextOptions<AddressContext> opts)
        : base(opts)
    {

    }

    protected override void OnModelCreating(ModelBuilder builder)
    {

    }
}
