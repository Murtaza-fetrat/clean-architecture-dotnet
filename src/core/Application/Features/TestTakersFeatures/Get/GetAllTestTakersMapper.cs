using Application.Domain.Entities;
using AutoMapper;


namespace Application.Features.TestTakersFeatures.Get
{
    public sealed class GetAllTestTakersMapper : Profile
    {
        public GetAllTestTakersMapper()
        {
            CreateMap<TestTakers, GetAllTestTakersResponse>();
        }
    }
}
