using System;
using System.Collections.Generic;

namespace WebProject.Modelss
{
    public partial class OrdersDetail
    {
        public int Id { get; set; }
        public int OrdersId { get; set; }
        public string Name { get; set; } = null!;
        public decimal Price { get; set; }
        public int Quantity { get; set; }
    }
}
