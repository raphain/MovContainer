
using System;

namespace MovContainer.Models
{
    public class Movimentation
    {
        public int Id { get; set; }

        public int MovTypeId { get; set; }

        public MovType MovType { get; set; }

        public int ContainerId { get; set; }

        public Container Container { get; set; }

        public DateTime Dt_Init { get; set; }

        public DateTime Dt_Fin { get; set; }

    }
}
