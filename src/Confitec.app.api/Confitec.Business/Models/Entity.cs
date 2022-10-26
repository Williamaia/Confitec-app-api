using System;
using System.Collections.Generic;
using System.Text;

namespace Confitec.Business.Models
{
    public abstract class Entity
    {
        protected Entity()
        {
            Id = 0;
        }

        public int Id { get; set; }
    }
}
