using System;
using System.Collections.Generic;

namespace WebProject.Modelsss
{
    public partial class Newslivemange
    {
        /// <summary>
        /// 直播管理ID
        /// </summary>
        public int LivemId { get; set; }
        /// <summary>
        /// 影片名稱
        /// </summary>
        public string LivemName { get; set; } = null!;
        /// <summary>
        /// YouTube頻道ID
        /// </summary>
        public string? LivemChannelCode { get; set; }
        /// <summary>
        /// fb直播id
        /// </summary>
        public string? LivemFb { get; set; }
        /// <summary>
        /// YouTube節目直播ID
        /// </summary>
        public string? LivemCode { get; set; }
        /// <summary>
        /// 上架時間
        /// </summary>
        public DateTime LivemBegdate { get; set; }
        /// <summary>
        /// Y:啟用;N:不啟用;D:刪除
        /// </summary>
        public string LivemIson { get; set; } = null!;
        /// <summary>
        /// 瀏覽人數
        /// </summary>
        public decimal LivemViewct { get; set; }
        /// <summary>
        /// 導購延伸按鈕名稱
        /// </summary>
        public string? LivemExName { get; set; }
        /// <summary>
        /// 導購延伸網址
        /// </summary>
        public string? LivemExUrl { get; set; }
        /// <summary>
        /// 直播管理圖片
        /// </summary>
        public string? LiveImg { get; set; }
        /// <summary>
        /// Y:顯示首頁
        /// N:否
        /// </summary>
        public string? LivemIndex { get; set; }
        /// <summary>
        /// Y:顯示於文章內頁
        /// N:否
        /// </summary>
        public string? LivemInside { get; set; }
        /// <summary>
        /// 排序
        /// </summary>
        public int LivemSort { get; set; }
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
        /// <summary>
        /// 新增者對應ADMIN_ID
        /// </summary>
        public string CreateUser { get; set; } = null!;
        /// <summary>
        /// 修改者IP
        /// </summary>
        public string UpdateIp { get; set; } = null!;
        /// <summary>
        /// 新增者IP
        /// </summary>
        public string CreateIp { get; set; } = null!;
    }
}
