using RealEstate.Domain.Entity;

namespace RealEstate.Domain.Properties
{
    public class Property : BaseEntity
    {
        public string? Title { get; private set; }
        public string? Description { get; private set; }
        public string? Location { get; private set; }
        public decimal Price { get; private set; }
        public PropertyStatus Status { get; private set; }
        public int RealtorId { get; private set; }
    }

    public enum PropertyStatus
    {
        Available,
        Reserved,
        Sold
    }

}
