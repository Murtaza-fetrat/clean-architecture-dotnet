using MediatR;

namespace Application.Features.TestTakersFeatures.Get
{
    public sealed record GetAllTestTakersRequest : IRequest<List<GetAllTestTakersResponse>>;
}
