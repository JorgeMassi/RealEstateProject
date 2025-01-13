using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RealEstate.Domain.Entity
{
    public class BaseEntity
    {
        public Guid Guid { get; set; }
        //public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
        //public string? CreatedBy { get; set; }
        //public DateTime? UpdatedAt { get; set; }
        //public string? UpdatedBy { get; set; }

    }
}
