using System;
using System.Collections.Generic;

namespace WebProject.Modelsss
{
    public partial class Newsyoutubeviewct
    {
        /// <summary>
        /// YOUTUBE觀看次數記錄ID
        /// </summary>
        public int YoutubevcId { get; set; }
        /// <summary>
        /// 對應節目頻道CHANEL_ID
        /// </summary>
        public int YoutubevcChanelId { get; set; }
        /// <summary>
        /// YOUTUBE ID
        /// </summary>
        public string YoutubevcVideoId { get; set; } = null!;
        /// <summary>
        /// 新增日期
        /// </summary>
        public DateTime YoutubevcDate { get; set; }
        /// <summary>
        /// 觀看次數
        /// </summary>
        public decimal YoutubevcVcount { get; set; }
    }
}
