using System;
using System.Collections.Generic;

namespace WebProject.Modelsss
{
    public partial class NewsactKeyword
    {
        /// <summary>
        /// 對應ACT_ID
        /// </summary>
        public int ActKeywordId { get; set; }
        /// <summary>
        /// 相關關鍵字
        /// </summary>
        public string ActKeyword { get; set; } = null!;
    }
}
