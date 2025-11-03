
using ErrorOr;
using MediatR;
using SFS.Domain.Contracts;
using SFS.Shared.Dtos;

namespace SFS.Application;

public sealed record GetDocHeadBySerNoQuery(string DocSerNo) : IRequest<ErrorOr<DocHeadDto>>;

internal sealed class GetDocHeadBySerNoQueryHandler : IRequestHandler<GetDocHeadBySerNoQuery, ErrorOr<DocHeadDto>>
{
    private readonly IDocHeadRepository _docHeadRepository;

    public GetDocHeadBySerNoQueryHandler(IDocHeadRepository docHeadRepository)
    {
        this._docHeadRepository = docHeadRepository;
    }

    public async Task<ErrorOr<DocHeadDto>> Handle(GetDocHeadBySerNoQuery request, CancellationToken cancellationToken)
    {
        var result = await _docHeadRepository.GetDocHeadByDocSerNoAsync(request.DocSerNo, cancellationToken);
        if (result is null) return Error.NotFound("");
        return result;
    }
}
