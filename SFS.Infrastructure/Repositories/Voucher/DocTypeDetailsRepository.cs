
using System.Threading;
using Microsoft.EntityFrameworkCore;
using SFS.Domain.Contracts;
using SFS.Shared.Dtos;

namespace SFS.Infrastructure;

internal class DocTypeDetailsRepository : IDocTypeDetails
{
    private readonly IDbContextFactory<ApplicationDbContext> _applicationDbContext;

    public DocTypeDetailsRepository(IDbContextFactory<ApplicationDbContext> applicationDbContext)
    {
        _applicationDbContext = applicationDbContext;
    }

    public async Task<IEnumerable<DocTypeDetailDto>> GetDocTypeDetailsByDocSerNo(string docSerNo, CancellationToken cancellationToken)
    {
        await using var context = await _applicationDbContext.CreateDbContextAsync(cancellationToken);
        return null;
    }
}
