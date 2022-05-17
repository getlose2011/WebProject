using System;
using System.Collections.Generic;

namespace WebProject.Modelsss
{
    public partial class Newstopic
    {
        /// <summary>
        /// 話題管理ID
        /// </summary>
        public int TopicId { get; set; }
        /// <summary>
        /// 話題名稱
        /// </summary>
        public string TopicName { get; set; } = null!;
        /// <summary>
        /// 資料型態
        /// 1:關鍵字文章
        /// 2:外部連結
        /// </summary>
        public int TopicKind { get; set; }
        /// <summary>
        /// 話題圖片(FOR APP)
        /// </summary>
        public string TopicImg { get; set; } = null!;
        /// <summary>
        /// 上線時間
        /// </summary>
        public DateTime? TopicBegdate { get; set; }
        public DateTime? TopicEnddate { get; set; }
        /// <summary>
        /// 連結網址
        /// </summary>
        public string TopicUrl { get; set; } = null!;
        /// <summary>
        /// 導購網址
        /// </summary>
        public string TopicRiderurl { get; set; } = null!;
        /// <summary>
        /// Y:顯示首頁;N:否
        /// </summary>
        public string TopicTop { get; set; } = null!;
        /// <summary>
        /// Y:本期話題;N:否
        /// </summary>
        public string TopicCurrent { get; set; } = null!;
        /// <summary>
        /// Y:啟用;N:不啟用;D:刪除
        /// </summary>
        public string TopicIson { get; set; } = null!;
        /// <summary>
        /// 其它相關關鍵字
        /// </summary>
        public string TopicKeyword { get; set; } = null!;
        /// <summary>
        /// 新增日期
        /// </summary>
        public DateTime CreateDate { get; set; }
        /// <summary>
        /// 修改日期
        /// </summary>
        public DateTime ModifyDate { get; set; }
        /// <summary>
        /// 新增者對應ADMIN_ID
        /// </summary>
        public string CreateUser { get; set; } = null!;
        /// <summary>
        /// 更新者對應ADMIN_ID
        /// </summary>
        public string UpdateUser { get; set; } = null!;
        /// <summary>
        /// 新增者IP
        /// </summary>
        public string CreateIp { get; set; } = null!;
        /// <summary>
        /// 修改者IP
        /// </summary>
        public string UpdateIp { get; set; } = null!;
        /// <summary>
        /// 話題排序
        /// </summary>
        public int TopicSort { get; set; }
    }
}
