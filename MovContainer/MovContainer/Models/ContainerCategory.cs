using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MovContainer.Models
{
    public class ContainerCategory
    {
        public int Id { get; set; }

        public string Description { get; set; }

        public List<Container> Containers { get; set; }

    }
}
