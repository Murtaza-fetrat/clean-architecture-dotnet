using Application.Domain.Entities;
using AutoMapper;


namespace Application.Features.TestTakersFeatures.Add
{
    public sealed class AddTestTakerMapper : Profile
    {
        public AddTestTakerMapper()
        {
            CreateMap<AddTestTakerRequest, TestTakers>();
            CreateMap<TestTakers, AddTestTakerResponse>();
        }
    }
}