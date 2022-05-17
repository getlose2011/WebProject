using System;
using System.Collections.Generic;

namespace WebProject.Modelsss
{
    public partial class Newsbanner
    {
        /// <summary>
        /// 廣告ID
        /// </summary>
        public int BannerId { get; set; }
        /// <summary>
        /// 廣告名稱
        /// </summary>
        public string BannerName { get; set; } = null!;
        /// <summary>
        /// 廣告商
        /// </summary>
        public string BannerVender { get; set; } = null!;
        /// <summary>
        /// 廣告摘要
        /// </summary>
        public string BannerSummary { get; set; } = null!;
        /// <summary>
        /// 對應NEWSFUNCTION_ID,目前原生廣告用FUNCTION_ZONE = 4
        /// </summary>
        public int BannerKind { get; set; }
        /// <summary>
        /// 廣告檔案
        /// </summary>
        public string BannerImg { get; set; } = null!;
        /// <summary>
        /// 影片
        /// </summary>
        public string BannerVideo { get; set; } = null!;
        /// <summary>
        /// 廣告網址
        /// </summary>
        public string BannerUrl { get; set; } = null!;
        /// <summary>
        /// 對應BANNER_ZONE_ID
        /// </summary>
        public int BannerZone { get; set; }
        /// <summary>
        /// 排序
        /// </summary>
        public int BannerSort { get; set; }
        /// <summary>
        /// 曝光次數(上限)
        /// </summary>
        public int BannerPvlimit { get; set; }
        /// <summary>
        /// 觸擊次數(上限)
        /// </summary>
        public int BannerClicklimit { get; set; }
        /// <summary>
        /// Y:啟用;N:不啟用;D:刪除
        /// </summary>
        public string BannerIson { get; set; } = null!;
        /// <summary>
        /// 啟用日期
        /// </summary>
        public DateTime BannerBegdate { get; set; }
        /// <summary>
        /// 結束日期
        /// </summary>
        public DateTime BannerEnddate { get; set; }
        /// <summary>
        /// 新增日期
        /// </summary>
        public DateTime CreateDate { get; set; }
        /// <summary>
        /// 修改日期
        /// </summary>
        public DateTime ModifyDate { get; set; }
        /// <summary>
        /// 更新者
        /// </summary>
        public string UpdateUser { get; set; } = null!;
        /// <summary>
        /// 曝光值
        /// </summary>
        public int BannerPv { get; set; }
        /// <summary>
        /// 點擊值
        /// </summary>
        public int BannerClick { get; set; }
        /// <summary>
        /// 對應NEWSFUNCTION_ID,目前原生廣告用FUNCTION_ZONE = 5
        /// </summary>
        public int BannerProperty { get; set; }
    }
}
