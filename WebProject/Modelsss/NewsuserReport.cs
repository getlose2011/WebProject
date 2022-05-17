using System;
using System.Collections.Generic;

namespace WebProject.Modelsss
{
    public partial class NewsuserReport
    {
        /// <summary>
        /// 爆料管理ID
        /// </summary>
        public int UrreportId { get; set; }
        /// <summary>
        /// 主旨
        /// </summary>
        public string UrreportSubject { get; set; } = null!;
        /// <summary>
        /// 姓名
        /// </summary>
        public string UrreportUname { get; set; } = null!;
        /// <summary>
        /// 電話
        /// </summary>
        public string UrreportTel { get; set; } = null!;
        /// <summary>
        /// email
        /// </summary>
        public string UrreportEmail { get; set; } = null!;
        /// <summary>
        /// 內容
        /// </summary>
        public string UrreportDesc { get; set; } = null!;
        /// <summary>
        /// 圖片或影片
        /// </summary>
        public string? UrreportFile { get; set; }
        /// <summary>
        /// 排序
        /// </summary>
        public int UrreportSort { get; set; }
        /// <summary>
        /// N 表示未處理 , Y 表示已經處理
        /// </summary>
        public string UrreportPower { get; set; } = null!;
        /// <summary>
        /// 來源者IP
        /// </summary>
        public string UrreportIp { get; set; } = null!;
        /// <summary>
        /// 新增日期
        /// </summary>
        public DateTime CreateDate { get; set; }
        /// <summary>
        /// 更新者對應ADMIN_ID
        /// </summary>
        public string UpdateUser { get; set; } = null!;
        /// <summary>
        /// 修改者日期
        /// </summary>
        public DateTime? ModifyDate { get; set; }
        /// <summary>
        /// 修改者IP
        /// </summary>
        public string UpdateIp { get; set; } = null!;
    }
}
