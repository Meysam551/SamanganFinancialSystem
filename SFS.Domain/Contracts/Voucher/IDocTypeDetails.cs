
using SFS.Shared.Dtos;

namespace SFS.Domain.Contracts;

public interface IDocTypeDetails
{
    Task<IEnumerable<DocTypeDetailDto>> GetDocTypeDetailsByDocSerNo(string docSerNo, CancellationToken cancellationToken);
}