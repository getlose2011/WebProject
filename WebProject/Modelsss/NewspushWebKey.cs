using System;
using System.Collections.Generic;

namespace WebProject.Modelsss
{
    public partial class NewspushWebKey
    {
        /// <summary>
        /// 存放web推播client key值ID
        /// </summary>
        public int WebpushId { get; set; }
        public string WebpushKey { get; set; } = null!;
        public DateTime CreateDate { get; set; }
    }
}
