using System;
using System.Collections.Generic;

namespace WebProject.Modelsss
{
    public partial class Newsact
    {
        /// <summary>
        /// 活動管理ID
        /// </summary>
        public int ActId { get; set; }
        /// <summary>
        /// 活動名稱
        /// </summary>
        public string ActName { get; set; } = null!;
        /// <summary>
        /// 資料型態
        /// 1:關鍵字文章
        /// 2:外部連結
        /// </summary>
        public int ActKind { get; set; }
        /// <summary>
        /// 活動圖片(FOR APP)
        /// </summary>
        public string ActImg { get; set; } = null!;
        /// <summary>
        /// 上線時間
        /// </summary>
        public DateTime? ActBegdate { get; set; }
        public DateTime? ActEnddate { get; set; }
        /// <summary>
        /// 連結網址
        /// </summary>
        public string ActUrl { get; set; } = null!;
        /// <summary>
        /// 導購網址
        /// </summary>
        public string ActRiderurl { get; set; } = null!;
        /// <summary>
        /// Y:啟用;N:不啟用;D:刪除
        /// </summary>
        public string ActIson { get; set; } = null!;
        /// <summary>
        /// 新聞關鍵字
        /// </summary>
        public string ActKeyword { get; set; } = null!;
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
        /// 活動排序
        /// </summary>
        public int ActSort { get; set; }
    }
}
