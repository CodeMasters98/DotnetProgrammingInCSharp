using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _19.RecordInCSharp.Models
{
    public record PersonDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }

    public record ProductDto2(int Id,string Name);
}
