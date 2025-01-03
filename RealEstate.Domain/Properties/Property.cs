using RealEstate.Domain.Entity;

namespace RealEstate.Domain.Properties
{
    public class Property : BaseEntity
    {
        public string? Title { get;  set; }
        public string? Description { get;  set; }
        public string? Location { get;  set; }
        public string? Image {  get;  set; }
        public decimal Price { get;  set; }
        public PropertyStatus Status { get;  set; }
        public int RealtorId { get;  set; }
    }

    public enum PropertyStatus
    {
        Available,
        Reserved,
        Sold
    }

}
