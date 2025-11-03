
using SFS.Shared.Dtos;

namespace SFS.Domain.Contracts;

public interface IDocHeadRepository
{
    Task<DocHeadDto> GetDocHeadByDocSerNoAsync(string docSerNo, CancellationToken cancellationToken);
}