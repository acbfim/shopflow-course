using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using shopflow.contract.Extensions;

namespace shopflow.contract.Model.Entities.Global
{
    public class BaseEntityInternal : BaseEntity
    {

        public string NormalizedName { get; private set; }
        public bool InternalProperty { get; set; } = false;


        private string _name;

        public string Name
        {
            get { return _name; }
            set {
                _name = value;
                NormalizedName = value.ToNormalized();
            }
        }
    }
}