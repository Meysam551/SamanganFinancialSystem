
using System.Data;
using Dapper;
using Microsoft.EntityFrameworkCore;
using SFS.Domain.Contracts;
using SFS.Shared.Dtos;

namespace SFS.Infrastructure;

public class DocDetailRepository : IDocDetailRepository
{
    private readonly IDbContextFactory<ApplicationDbContext> _applicationDbContext;

    public DocDetailRepository(IDbContextFactory<ApplicationDbContext> applicationDbContext)
    {
        this._applicationDbContext = applicationDbContext;
    }

    public async Task<IEnumerable<DocDetailDto>> GetDocDetailRowsByDocSerNoAsync(int docSerNo, CancellationToken cancellationToken)
    {
        await using var context = await _applicationDbContext.CreateDbContextAsync(cancellationToken);
        var connection = context.Database.GetDbConnection();

        // اگر کانکشن باز نیست، بازش کن
        if (connection.State != ConnectionState.Open)
            await connection.OpenAsync(cancellationToken);

        var sql = "SELECT * FROM [dbo].[Get_DocDetailRowsByDocSerNo](@DocSerNo)";
        var result = await connection.QueryAsync<DocDetailDto>(sql, new { DocSerNo = docSerNo });

        return result;
    }
}