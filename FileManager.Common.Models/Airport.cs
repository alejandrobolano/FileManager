using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileManager.Common.Models
{
    public class Airport
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string Country { get; set; }

        public override bool Equals(object obj)
        {
            return obj is Airport airport &&
                   Id == airport.Id &&
                   Name == airport.Name &&
                   Country == airport.Country;
        }

        public override int GetHashCode()
        {
            var hashCode = 187117927;
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(Id);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(Name);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(Country);
            return hashCode;
        }
    }
}
