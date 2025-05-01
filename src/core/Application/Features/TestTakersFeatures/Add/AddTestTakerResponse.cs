namespace Application.Features.TestTakersFeatures.Add
{
    public sealed record class AddTestTakerResponse
    {
        public Guid ID { get; set; }
        public string BannerID { get; set; } = null!;
    }
}
