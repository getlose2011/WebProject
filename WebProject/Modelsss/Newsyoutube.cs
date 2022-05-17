using System;
using System.Collections.Generic;

namespace WebProject.Modelsss
{
    public partial class Newsyoutube
    {
        /// <summary>
        /// 精彩節目清單YOUTUBE ID
        /// </summary>
        public string YoutubeVideoId { get; set; } = null!;
        /// <summary>
        /// 對應節目頻道CHANEL_ID
        /// </summary>
        public int YoutubeChanelId { get; set; }
        /// <summary>
        /// YOUTUBE標題
        /// </summary>
        public string YoutubeTitle { get; set; } = null!;
        /// <summary>
        /// YOUTUBE說明
        /// </summary>
        public string YoutubeDesc { get; set; } = null!;
        /// <summary>
        /// YOUTUBE圖片
        /// </summary>
        public string YoutubeImg { get; set; } = null!;
        /// <summary>
        /// YOUTUBE分類
        /// </summary>
        public string YoutubeCategory { get; set; } = null!;
        /// <summary>
        /// Y:啟用;N:不啟用;D:刪除
        /// </summary>
        public string YoutubeIson { get; set; } = null!;
        /// <summary>
        /// YOUTUBE發布時間
        /// </summary>
        public DateTime YoutubePublishedDate { get; set; }
        /// <summary>
        /// 修改日期
        /// </summary>
        public DateTime ModifyDate { get; set; }
        /// <summary>
        /// 更新者
        /// </summary>
        public string UpdateUser { get; set; } = null!;
        /// <summary>
        /// 影片瀏覽次數
        /// </summary>
        public decimal ViewCount { get; set; }
        /// <summary>
        /// 影片長度
        /// </summary>
        public string Videolen { get; set; } = null!;
        public int? YoutubeTopicId { get; set; }
    }
}
