using System;
using System.Collections.Generic;

namespace WebProject.Modelss
{
    public partial class Foobar
    {
        public Guid Id { get; set; }
        public string Name { get; set; } = null!;
        public string Categories { get; set; } = null!;
        public DateTime CreateDate { get; set; }
        public DateTime UpdateDate { get; set; }
    }
}
