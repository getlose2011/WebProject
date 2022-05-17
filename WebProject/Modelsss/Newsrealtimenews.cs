using System;
using System.Collections.Generic;

namespace WebProject.Modelsss
{
    public partial class Newsrealtimenews
    {
        /// <summary>
        /// 即時新聞快訊ID
        /// </summary>
        public int RealtimeId { get; set; }
        /// <summary>
        /// 即時新聞快訊標題
        /// </summary>
        public string RealtimeName { get; set; } = null!;
        /// <summary>
        /// 上架時間
        /// </summary>
        public DateTime RealtimeBegdate { get; set; }
        /// <summary>
        /// 下架時間
        /// </summary>
        public DateTime RealtimeEnddate { get; set; }
        /// <summary>
        /// 連結網址(新聞ID或外部網址)
        /// </summary>
        public string? RealtimeUrl { get; set; }
        /// <summary>
        /// Y:啟用;N:不啟用;D:刪除
        /// </summary>
        public string RealtimeIson { get; set; } = null!;
        /// <summary>
        /// Y:進推播系統;N:否
        /// </summary>
        public string RealtimePush { get; set; } = null!;
        /// <summary>
        /// 排序
        /// </summary>
        public int RealtimeSort { get; set; }
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
        /// 短標題
        /// </summary>
        public string? RealtimeSubjectShort { get; set; }
    }
}
