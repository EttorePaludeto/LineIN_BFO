using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LineIN.BFO.Web.Models
{
    public abstract class EntityVM
    {
        public Guid Id { get; private set; }

        public EntityVM()
        {
            Id = Guid.NewGuid();
        }
    }
}
