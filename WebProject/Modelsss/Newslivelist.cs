using System;
using System.Collections.Generic;

namespace WebProject.Modelsss
{
    public partial class Newslivelist
    {
        /// <summary>
        /// 直播清單ID
        /// </summary>
        public int LiveId { get; set; }
        /// <summary>
        /// 1:24小時直播連結;2:直播管理
        /// </summary>
        public int LiveKind { get; set; }
        /// <summary>
        /// 直播名稱
        /// </summary>
        public string LiveName { get; set; } = null!;
        /// <summary>
        /// Youtube描述
        /// </summary>
        public string LiveDescription { get; set; } = null!;
        /// <summary>
        /// YT Uname
        /// </summary>
        public string LiveChanel { get; set; } = null!;
        /// <summary>
        /// 圖片
        /// </summary>
        public string LiveImg { get; set; } = null!;
        /// <summary>
        /// fb直播id
        /// </summary>
        public string LiveFb { get; set; } = null!;
        /// <summary>
        /// 節目ID
        /// </summary>
        public string LiveUrl { get; set; } = null!;
        /// <summary>
        /// 開始日期
        /// </summary>
        public DateTime? LiveBegdate { get; set; }
        /// <summary>
        /// 結束日期
        /// </summary>
        public DateTime? LiveEnddate { get; set; }
        /// <summary>
        /// 啟用時間
        /// </summary>
        public TimeSpan LiveBegtime { get; set; }
        /// <summary>
        /// 結束時間
        /// </summary>
        public TimeSpan LiveEndtme { get; set; }
        /// <summary>
        /// 開放星期
        /// </summary>
        public string LiveWeek { get; set; } = null!;
        /// <summary>
        /// Y:啟用;N:不啟用;D:刪除
        /// </summary>
        public string LiveIson { get; set; } = null!;
        /// <summary>
        /// 置頂Y:是;N;否
        /// </summary>
        public string LiveTop { get; set; } = null!;
        /// <summary>
        /// 排序
        /// </summary>
        public int LiveSort { get; set; }
        /// <summary>
        /// 留言版Y:啟用(關聯NEWSLIVE_BOARD);N不啟用
        /// </summary>
        public string LiveBoardIson { get; set; } = null!;
        /// <summary>
        /// 瀏覽人數
        /// </summary>
        public decimal LiveViewct { get; set; }
        /// <summary>
        /// 新增日期
        /// </summary>
        public DateTime CreateDate { get; set; }
        /// <summary>
        /// 更新日期
        /// </summary>
        public DateTime ModifyDate { get; set; }
        /// <summary>
        /// 更新者ADMIN_ID
        /// </summary>
        public string UpdateUser { get; set; } = null!;
    }
}
