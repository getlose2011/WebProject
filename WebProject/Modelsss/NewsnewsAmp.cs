using System;
using System.Collections.Generic;

namespace WebProject.Modelsss
{
    public partial class NewsnewsAmp
    {
        /// <summary>
        /// AMP新聞ID
        /// </summary>
        public int AmpId { get; set; }
        /// <summary>
        /// 新聞ID對應NEWSNEWS之NEWS_ID
        /// </summary>
        public int NewsId { get; set; }
        /// <summary>
        /// AMP新聞內容
        /// </summary>
        public string NewsContentsAmp { get; set; } = null!;
    }
}
