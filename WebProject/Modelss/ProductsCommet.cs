using System;
using System.Collections.Generic;

namespace WebProject.Modelss
{
    public partial class ProductsCommet
    {
        public int Id { get; set; }
        public string UserId { get; set; } = null!;
        public string Content { get; set; } = null!;
        public DateTime CreateDate { get; set; }
        public int ProductsId { get; set; }
    }
}
