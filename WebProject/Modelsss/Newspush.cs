using System;
using System.Collections.Generic;

namespace WebProject.Modelsss
{
    public partial class Newspush
    {
        public int PushId { get; set; }
        /// <summary>
        /// 排程時間
        /// </summary>
        public DateTime PushDatetime { get; set; }
        /// <summary>
        /// 標題
        /// </summary>
        public string PushTitle { get; set; } = null!;
        /// <summary>
        /// (&apos;&apos;)
        /// </summary>
        public string? PushUrl { get; set; }
        /// <summary>
        /// 新聞ID
        /// </summary>
        public int? PushNewsId { get; set; }
        /// <summary>
        /// Y:已經發送;N:未發送;D:刪除
        /// </summary>
        public string PushIson { get; set; } = null!;
        /// <summary>
        /// 是否推送成功 1:已推播 0:未推播
        /// </summary>
        public int PushAws { get; set; }
        /// <summary>
        /// 新增日期
        /// </summary>
        public DateTime PushCreateDate { get; set; }
        /// <summary>
        /// 修改日期
        /// </summary>
        public DateTime PushModifyDate { get; set; }
        /// <summary>
        /// 更新者
        /// </summary>
        public string UpdateUser { get; set; } = null!;
    }
}
