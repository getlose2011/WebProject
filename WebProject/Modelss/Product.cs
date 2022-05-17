using System;
using System.Collections.Generic;

namespace WebProject.Modelss
{
    public partial class Product
    {
        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public string Description { get; set; } = null!;
        public int CategorId { get; set; }
        public decimal Price { get; set; }
        public bool Status { get; set; }
        public DateTime PublishDate { get; set; }
        public long? DefaultImageId { get; set; }
        public int Quantity { get; set; }
        public string? DefaultImageUrl { get; set; }
        public string? Path { get; set; }
    }
}
