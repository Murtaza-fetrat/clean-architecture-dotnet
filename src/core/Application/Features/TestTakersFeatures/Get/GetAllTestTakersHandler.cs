using Application.Repository.TestTakersRepository;
using AutoMapper;
using MediatR;


namespace Application.Features.TestTakersFeatures.Get
{
    public sealed class GetAllTestTakersHandler : IRequestHandler<GetAllTestTakersRequest, List<GetAllTestTakersResponse>>
    {
        private readonly ITestTakerRepository _TestTakerRepository;
        private readonly IMapper _mapper;

        public GetAllTestTakersHandler(ITestTakerRepository TestTakersRepository, IMapper mapper)
        {
            _TestTakerRepository = TestTakersRepository;
            _mapper = mapper;
        }

        public async Task<List<GetAllTestTakersResponse>> Handle(GetAllTestTakersRequest request, CancellationToken cancellationToken)
        {
            var TestTakerss = await _TestTakerRepository.GetAll(cancellationToken);
            return _mapper.Map<List<GetAllTestTakersResponse>>(TestTakerss);
        }
    }
}
