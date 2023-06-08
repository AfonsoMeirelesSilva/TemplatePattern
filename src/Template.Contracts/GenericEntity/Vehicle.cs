using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Template.Contracts.GenericEntity
{
    public class Vehicle
    {
        public string Identification { get; set; }
        public int Year { get; set; }
        public string Color { get; set; }
        public string Model { get; set; }
        public int Kilometers { get; set; }
        public IEnumerable<Service> Services{ get; set; }
    }
}
