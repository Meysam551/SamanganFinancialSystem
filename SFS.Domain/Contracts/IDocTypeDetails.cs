
using SFS.Shared;

namespace SFS.Domain.Contracts;

public interface IDocTypeDetails
{
    Task<IEnumerable<DocTypeDetailDto>> GetDocTypeDetailsByDocSerNoAsync(string docSerNo, string docCode, CancellationToken cancellationToken);
}