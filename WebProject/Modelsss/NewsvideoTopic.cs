using System;
using System.Collections.Generic;

namespace WebProject.Modelsss
{
    public partial class NewsvideoTopic
    {
        /// <summary>
        /// 影音分類主題ID
        /// </summary>
        public int VideoTopicId { get; set; }
        /// <summary>
        /// 分類主題影音名稱
        /// </summary>
        public string VideoTopicName { get; set; } = null!;
        /// <summary>
        /// 分類主題影片來源型態1.youtube頻道、2.yt播放清單 
        /// </summary>
        public int VideoTopicType { get; set; }
        /// <summary>
        /// YouTube頻道ID/播放清單ID
        /// </summary>
        public string VideoTopicCode { get; set; } = null!;
        /// <summary>
        /// 分類主題影音延伸按鈕名稱
        /// </summary>
        public string? VideoTopicExName { get; set; }
        /// <summary>
        /// 分類主題影音延伸網址
        /// </summary>
        public string? VideoTopicExUrl { get; set; }
        /// <summary>
        /// 分類主題影音狀態 Y:有效 N:下檔 D:刪除
        /// </summary>
        public string VideoTopicIson { get; set; } = null!;
        /// <summary>
        /// 分類主題影音排序
        /// </summary>
        public int VideoTopicSort { get; set; }
        /// <summary>
        /// 對應NEWSVIDEO_CHANEL的CHANEL_ID (節目影音ID)
        /// </summary>
        public int ChanelId { get; set; }
        /// <summary>
        /// 建立資料者
        /// </summary>
        public string CreateUser { get; set; } = null!;
        /// <summary>
        /// 更新資料者
        /// </summary>
        public string UpdateUser { get; set; } = null!;
        /// <summary>
        /// 建立者IP
        /// </summary>
        public string CreateIp { get; set; } = null!;
        /// <summary>
        /// 更新者IP
        /// </summary>
        public string UpdateIp { get; set; } = null!;
        public DateTime ModifyDate { get; set; }
        public DateTime CreateDate { get; set; }
    }
}
