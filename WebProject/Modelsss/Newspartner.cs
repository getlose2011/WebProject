using System;
using System.Collections.Generic;

namespace WebProject.Modelsss
{
    public partial class Newspartner
    {
        /// <summary>
        /// 合作夥伴管理ID
        /// </summary>
        public int PartnerId { get; set; }
        /// <summary>
        /// 夥伴名稱
        /// </summary>
        public string PartnerName { get; set; } = null!;
        /// <summary>
        /// 夥伴網址
        /// </summary>
        public string PartnerUrl { get; set; } = null!;
        /// <summary>
        /// RSS網址
        /// </summary>
        public string PartnerRss { get; set; } = null!;
        /// <summary>
        /// LOGO
        /// </summary>
        public string PartnerLogo { get; set; } = null!;
        /// <summary>
        /// 2:須再點「匯入」的時候把rss資料帶到新增新聞的編輯區;1有新文章自動發佈到”已上線”
        /// </summary>
        public string PartnerAuto { get; set; } = null!;
        /// <summary>
        /// 主分類對應CATEGORY_ID
        /// </summary>
        public int PartnerCategoryId { get; set; }
        /// <summary>
        /// 次分類對應CATEGORY_ID
        /// </summary>
        public string PartnerCategoryIdSub { get; set; } = null!;
        /// <summary>
        /// 新聞類型(1:旅遊美食;2:愛玩車)
        /// </summary>
        public int PartnerOthernews { get; set; }
        /// <summary>
        /// Y:啟用;N:不啟用
        /// </summary>
        public string PartnerIson { get; set; } = null!;
        /// <summary>
        /// 新增日期
        /// </summary>
        public DateTime PartnerCreterDate { get; set; }
        /// <summary>
        /// 新增者
        /// </summary>
        public string PartnerCreterUser { get; set; } = null!;
        /// <summary>
        /// 更新日期
        /// </summary>
        public DateTime PartnerModifyDate { get; set; }
        /// <summary>
        /// 更新者
        /// </summary>
        public string PartnerUpdateUser { get; set; } = null!;
    }
}
