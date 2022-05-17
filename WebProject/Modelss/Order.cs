using System;
using System.Collections.Generic;

namespace WebProject.Modelss
{
    public partial class Order
    {
        public int Id { get; set; }
        public string UserId { get; set; } = null!;
        public string RecieverName { get; set; } = null!;
        public string RecieverPhone { get; set; } = null!;
        public string RecieverAddress { get; set; } = null!;
    }
}
