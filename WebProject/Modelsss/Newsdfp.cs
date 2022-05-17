using System;
using System.Collections.Generic;

namespace WebProject.Modelsss
{
    public partial class Newsdfp
    {
        public int DfpId { get; set; }
        /// <summary>
        /// DFP代碼
        /// </summary>
        public string DfpCode { get; set; } = null!;
        /// <summary>
        /// DFP區域
        /// </summary>
        public int DfpArea { get; set; }
        /// <summary>
        /// 1:web 2:app
        /// </summary>
        public int DfpPlatform { get; set; }
        /// <summary>
        /// DFP對應新聞分類ID (對應NewsCategory)
        /// </summary>
        public int? CategoryId { get; set; }
        public int? ChanelId { get; set; }
        /// <summary>
        /// 建立時間
        /// </summary>
        public DateTime CreateDate { get; set; }
        /// <summary>
        /// DFP SIZE
        /// </summary>
        public string? DfpSize { get; set; }
    }
}
