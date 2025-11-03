
using ErrorOr;
using MediatR;
using SFS.Domain.Contracts;
using SFS.Shared;

namespace SFS.Application;

public sealed record GetDocTypeDetailsQuery(string DocSerNo, string DocCode) : IRequest<ErrorOr<IEnumerable<DocTypeDetailDto>>>;

internal sealed class GetDocTypeDetailsQueryHandler : IRequestHandler<GetDocTypeDetailsQuery, ErrorOr<IEnumerable<DocTypeDetailDto>>>
{
    private readonly IDocTypeDetails _docTypeRepository;

    public GetDocTypeDetailsQueryHandler(IDocTypeDetails docTypeRepository)
    {
        this._docTypeRepository = docTypeRepository;
    }

    public async Task<ErrorOr<IEnumerable<DocTypeDetailDto>>> Handle(GetDocTypeDetailsQuery request, CancellationToken cancellationToken)
    {
        var list = await _docTypeRepository.GetDocTypeDetailsByDocSerNoAsync(request.DocSerNo, request.DocCode, cancellationToken);
        if (list == null) return Error.NotFound($"هیچ موردی ثبت نشده است");
        return ErrorOrFactory.From(list);
    }
}
