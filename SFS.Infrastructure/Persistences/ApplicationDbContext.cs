
using System.Reflection;
using MediatR;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using SFS.Domain.Entities;

namespace SFS.Infrastructure;

public class ApplicationDbContext : BaseDbContext
{
    private readonly IMediator _mediator;
    public DbSet<DocTypeDetail> DocTypeDetails => Set<DocTypeDetail>();

    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
    : base(options) { }

    [ActivatorUtilitiesConstructor]
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options, IMediator mediator)
        : base(options)
    {
        _mediator = mediator;
    }

    protected override void OnModelCreating(ModelBuilder builder)
    {
        //builder.HasDefaultSchema("figa");

        base.OnModelCreating(builder);
        builder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());

    }
}
