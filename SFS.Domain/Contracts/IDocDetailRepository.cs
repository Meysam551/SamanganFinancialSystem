
using SFS.Shared.Dtos;

namespace SFS.Domain.Contracts;

public interface IDocDetailRepository
{
    Task<IEnumerable<DocDetailDto>> GetDocDetailRowsByDocSerNoAsync(int docSerNo, CancellationToken cancellationToken);
}