
using MediatR;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace SFS.Infrastructure;

public class DbContextFactory
{
    private readonly IConfiguration _configuration;
    private readonly IMediator _mediator;

    public DbContextFactory(IConfiguration configuration, IMediator mediator)
    {
        _configuration = configuration;
        this._mediator = mediator;
    }

    public ApplicationDbContext CreateDbContext()
    {
        var optionsBuilder = new DbContextOptionsBuilder<ApplicationDbContext>();
        var databaseProvider = _configuration["DatabaseProvider"];

        switch (databaseProvider)
        {
            case "MsSql":
                optionsBuilder.UseSqlServer("Data Source=AutomaticTransmissionDb.db;");
                break;

            default:
                throw new InvalidOperationException("Unsupported database provider");
        }

        return new ApplicationDbContext(optionsBuilder.Options, _mediator);
    }
}