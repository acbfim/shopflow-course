using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace shopflow.contract.Model.Entities.Global
{
    public class BaseEntity : IBaseEntity
    {
        public long Id { get; set; }
        public DateTime Timestamp { get; set; } = DateTime.UtcNow;
        public bool IsActive { get; set; } = true;
    }
}