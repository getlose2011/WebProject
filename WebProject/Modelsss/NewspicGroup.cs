using System;
using System.Collections.Generic;

namespace WebProject.Modelsss
{
    public partial class NewspicGroup
    {
        /// <summary>
        /// 圖輯簿ID
        /// </summary>
        public int PicGroupId { get; set; }
        /// <summary>
        /// 圖輯名稱
        /// </summary>
        public string PicGroupName { get; set; } = null!;
        /// <summary>
        /// Y:顯示;N:不顯示;D:刪除
        /// </summary>
        public string PicGroupIson { get; set; } = null!;
        public DateTime CreateDate { get; set; }
        public DateTime ModifyDate { get; set; }
        /// <summary>
        /// 更新者對應ADMIN_ID
        /// </summary>
        public string UpdateUser { get; set; } = null!;
        /// <summary>
        /// 更新者IP
        /// </summary>
        public string UpdateIp { get; set; } = null!;
        /// <summary>
        /// 新增者IP
        /// </summary>
        public string CreateIp { get; set; } = null!;
    }
}
