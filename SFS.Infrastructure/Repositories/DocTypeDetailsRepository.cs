
using System.Data;
using Dapper;
using Microsoft.EntityFrameworkCore;
using SFS.Domain.Contracts;
using SFS.Shared;

namespace SFS.Infrastructure;

public class DocTypeDetailsRepository : IDocTypeDetails
{
    private readonly IDbContextFactory<ApplicationDbContext> _applicationDbContext;

    public DocTypeDetailsRepository(IDbContextFactory<ApplicationDbContext> applicationDbContext)
    {
        _applicationDbContext = applicationDbContext;
    }

    public async Task<IEnumerable<DocTypeDetailDto>> GetDocTypeDetailsByDocSerNoAsync(
        string docSerNo, string docCode,
        CancellationToken cancellationToken)
    {
        await using var context = await _applicationDbContext.CreateDbContextAsync(cancellationToken);
        var connection = context.Database.GetDbConnection();

        // اگر کانکشن باز نیست، بازش کن
        if (connection.State != ConnectionState.Open)
            await connection.OpenAsync(cancellationToken);

        var sql = "SELECT * FROM dbo.GetDocTypeDetailsByDocSerNo(@DocSerNo)";
        var result = await connection.QueryAsync<DocTypeDetailDto>(sql, new { DocSerNo = docSerNo, DocCode = docCode });

        return result;
    }
}
