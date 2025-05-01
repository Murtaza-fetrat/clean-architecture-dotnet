using Application.Domain.Entities;
using Application.Repository;
using Application.Repository.TestTakersRepository;
using AutoMapper;
using MediatR;


namespace Application.Features.TestTakersFeatures.Add
{
    public sealed class AddTestTakerHandler : IRequestHandler<AddTestTakerRequest, AddTestTakerResponse>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly ITestTakerRepository _testTakerRepository;
        private readonly IMapper _mapper;

        public AddTestTakerHandler(IUnitOfWork unitOfWork, 
            ITestTakerRepository testTakerRepository, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _testTakerRepository = testTakerRepository;
            _mapper = mapper;
        }

        public async Task<AddTestTakerResponse> Handle(AddTestTakerRequest request,
            CancellationToken cancellationToken)
        {
            var user = _mapper.Map<TestTakers>(request);
            _testTakerRepository.Create(user);
            await _unitOfWork.Save(cancellationToken);

            return _mapper.Map<AddTestTakerResponse>(user);
        }


    }
}
