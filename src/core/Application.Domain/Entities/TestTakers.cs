using Application.Domain.Common;

namespace Application.Domain.Entities
{
    public class TestTakers : BaseEntity
    {
        public string Email { get; set; } = null!;
        public string FirstName { get; set; } = null!;
		public string LastName { get; set; } = null!;
		public string FormNumber { get; set; } = null!;
		public string BannerID { get; set; } = null!;
	}
}
