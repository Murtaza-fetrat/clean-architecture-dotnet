namespace Application.Features.TestTakersFeatures.Get
{
    public sealed record GetAllTestTakersResponse
    {
        public Guid ID { get; set; }
        public string Email { get; set; } = null!;
        public string FirstName { get; set; } = null!;
		public string LastName { get; set; } = null!;
		public string FormNumber { get; set; } = null!;
		public string BannerID { get; set; } = null!;
	}
}
