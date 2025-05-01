using MediatR;


namespace Application.Features.TestTakersFeatures.Add
{
    public sealed record AddTestTakerRequest(string Email, string FirstName, string LastName, string BannerID, string FormNumber) : IRequest<AddTestTakerResponse>;
}
