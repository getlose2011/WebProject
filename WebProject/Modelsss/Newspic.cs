using System;
using System.Collections.Generic;

namespace WebProject.Modelsss
{
    public partial class Newspic
    {
        /// <summary>
        /// 圖輯相片ID
        /// </summary>
        public int PicId { get; set; }
        /// <summary>
        /// 對應圖輯簿PIC_GROUP_ID
        /// </summary>
        public int PicGroupId { get; set; }
        /// <summary>
        /// 檔案名稱
        /// </summary>
        public string PicFilename { get; set; } = null!;
        /// <summary>
        /// 檔案大小
        /// </summary>
        public int? PicFilesize { get; set; }
        /// <summary>
        /// Y:顯示;N:不顯示;D:刪除
        /// </summary>
        public string PicIson { get; set; } = null!;
        public DateTime CreateDate { get; set; }
        /// <summary>
        /// 新增者IP
        /// </summary>
        public string CreateIp { get; set; } = null!;
        /// <summary>
        /// 修改日期
        /// </summary>
        public DateTime ModifyDate { get; set; }
        /// <summary>
        /// 修改者IP
        /// </summary>
        public string UpdateIp { get; set; } = null!;
    }
}
