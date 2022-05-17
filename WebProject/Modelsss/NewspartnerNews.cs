using System;
using System.Collections.Generic;

namespace WebProject.Modelsss
{
    public partial class NewspartnerNews
    {
        /// <summary>
        /// 合作夥伴管理新聞紀錄ID
        /// </summary>
        public int PnnewsId { get; set; }
        /// <summary>
        /// 對應PARNER_ID
        /// </summary>
        public int PnnewsPartnerId { get; set; }
        /// <summary>
        /// 主旨標題
        /// </summary>
        public string PnnewsSubject { get; set; } = null!;
        /// <summary>
        /// 摘要
        /// </summary>
        public string PnnewsSummary { get; set; } = null!;
        /// <summary>
        /// 新聞內容
        /// </summary>
        public string PnnewsContents { get; set; } = null!;
        /// <summary>
        /// 封面圖片
        /// </summary>
        public string PnnewsImg { get; set; } = null!;
        /// <summary>
        /// 記者姓名
        /// </summary>
        public string PnnewsReporter { get; set; } = null!;
        /// <summary>
        /// 主分類對應CATEGORY_ID
        /// </summary>
        public int PnnewsCategoryId { get; set; }
        /// <summary>
        /// 次分類對應CATEGORY_ID
        /// </summary>
        public string PnnewsCategoryIdSub { get; set; } = null!;
        /// <summary>
        /// 新聞類型(1:旅遊美食;2:愛玩車)
        /// </summary>
        public int PnnewsOthernews { get; set; }
        /// <summary>
        /// 匯入到新增新聞table時間
        /// </summary>
        public string PnnewsUpdateTime { get; set; } = null!;
        /// <summary>
        /// RSS資料匯入時間
        /// </summary>
        public DateTime PnnewsCretaeTime { get; set; }
        /// <summary>
        /// 更新者
        /// </summary>
        public string PnnewsUpdater { get; set; } = null!;
        /// <summary>
        /// 紀錄來源新聞網址
        /// </summary>
        public string PnnewsNewsLink { get; set; } = null!;
        /// <summary>
        /// 紀錄來源guid
        /// </summary>
        public string PnnewsGuid { get; set; } = null!;
        public string PnnewsNote { get; set; } = null!;
        /// <summary>
        /// 紀錄rss embed tag 裡的YouTube影片網址
        /// </summary>
        public string? PnnewsEmbedVideo { get; set; }
    }
}
