using System;
using Estudos_Csharp.Entities.Enums;

namespace Estudos_Csharp.Entities
{
    class Order
    {
        public int Id{ get; set; }
        public DateTime Moment { get; set; }
        public OrderStatus Status { get; set; }

        public override string ToString()
        {
            return Id
                + ", "
                + Moment
                + ", "
                + Status;
        }
    }
}
