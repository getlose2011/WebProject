using System;
using System.Collections.Generic;

namespace WebProject.Modelsss
{
    public partial class NewspushWeb
    {
        /// <summary>
        /// Web瀏覽器推播通知ID
        /// </summary>
        public int PushwebId { get; set; }
        /// <summary>
        /// 排程時間
        /// </summary>
        public DateTime PushwebDatetime { get; set; }
        /// <summary>
        /// 標題
        /// </summary>
        public string PushwebTitle { get; set; } = null!;
        /// <summary>
        /// (&apos;&apos;)
        /// </summary>
        public string? PushwebUrl { get; set; }
        /// <summary>
        /// 新聞ID
        /// </summary>
        public int? PushwebNewsId { get; set; }
        /// <summary>
        /// Y:已經發送;N:未發送;D:刪除
        /// </summary>
        public string PushwebIson { get; set; } = null!;
        /// <summary>
        /// 是否推送成功 1:已推播 0:未推播
        /// </summary>
        public int PushwebFirebase { get; set; }
        /// <summary>
        /// 新增日期
        /// </summary>
        public DateTime PushwebCreateDate { get; set; }
        /// <summary>
        /// 修改日期
        /// </summary>
        public DateTime PushwebModifyDate { get; set; }
        /// <summary>
        /// 更新者
        /// </summary>
        public string UpdateUser { get; set; } = null!;
    }
}
