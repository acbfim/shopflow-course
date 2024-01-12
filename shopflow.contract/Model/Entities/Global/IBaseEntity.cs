using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace shopflow.contract.Model.Entities.Global
{
    public interface IBaseEntity
    {
        public long Id { get; set; }
        public DateTime Timestamp { get; set; }
    }
}