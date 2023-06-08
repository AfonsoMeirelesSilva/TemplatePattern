using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Template.Contracts.GenericEntity
{
    public class Service
    {
        public Guid Id { get; set; }
        public IEnumerable<Mechanic> Mechanics { get; set; }
        public float Total { get; set; }
        public bool ServiceDone { get; set; }
        public DateTime? ServiceStartDate { get; set; }

        public Service()
        {
            ServiceStartDate = DateTime.Now;
        }
    }
}
