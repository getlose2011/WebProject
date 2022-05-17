using System;
using System.Collections.Generic;

namespace WebProject.Modelsss
{
    public partial class NewsbannerZone
    {
        /// <summary>
        /// 廣告版位ID
        /// </summary>
        public int BannerZoneId { get; set; }
        /// <summary>
        /// 版位名稱
        /// </summary>
        public string BannerZoneName { get; set; } = null!;
        /// <summary>
        /// 對應JSON欄位key
        /// </summary>
        public string BannerZoneMap { get; set; } = null!;
        /// <summary>
        /// 版位說明
        /// </summary>
        public string BannerZoneDesc { get; set; } = null!;
        /// <summary>
        /// Y:啟用;N:不啟用;D:刪除
        /// </summary>
        public string BannerZoneIson { get; set; } = null!;
        /// <summary>
        /// 新增日期
        /// </summary>
        public DateTime CreateDate { get; set; }
        /// <summary>
        /// 修改日期
        /// </summary>
        public DateTime ModifyDate { get; set; }
        /// <summary>
        /// 修改者ADMIN_ID
        /// </summary>
        public string UpdateUser { get; set; } = null!;
        /// <summary>
        /// 後台顯示用分類,對應NEWSFUNCTION_ID
        /// </summary>
        public int BannerZoneKind { get; set; }
        /// <summary>
        /// 前台顯示用分類,對應NEWSFUNCTION_ID
        /// </summary>
        public int BannerZoneKindFront { get; set; }
    }
}
