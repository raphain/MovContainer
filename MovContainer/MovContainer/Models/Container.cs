using MovContainer.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MovContainer.Models
{
    public class Container
    {
        public int Id { get; set; }

        public string Client { get; set; }

        public string Number { get; set; }

        public int ContainerTypeId { get; set; }
        public int ContainerStatusId { get; set; }
        public int ContainerCategoryId { get; set; }

        public ContainerType ContainerType { get; set; }

        public ContainerStatus Status { get; set; }

        public ContainerCategory Category { get; set; }

        public List<Movimentation> Movimentations { get; set; }

    }
}
