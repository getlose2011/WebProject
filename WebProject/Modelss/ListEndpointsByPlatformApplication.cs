using System;
using System.Collections.Generic;

namespace WebProject.Modelss
{
    public partial class ListEndpointsByPlatformApplication
    {
        public int Id { get; set; }
        public string Token { get; set; } = null!;
        public string EndpointArn { get; set; } = null!;
        public string Enabled { get; set; } = null!;
        public bool? CheckId { get; set; }
    }
}
