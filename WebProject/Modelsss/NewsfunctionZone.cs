using System;
using System.Collections.Generic;

namespace WebProject.Modelsss
{
    public partial class NewsfunctionZone
    {
        /// <summary>
        /// 功能版位ID
        /// </summary>
        public int FunctionZoneId { get; set; }
        /// <summary>
        /// 功能版位名稱
        /// </summary>
        public string FunctionZoneName { get; set; } = null!;
        /// <summary>
        /// 版位說明
        /// </summary>
        public string FunctionZoneDesc { get; set; } = null!;
        /// <summary>
        /// Y:啟用;N:不啟用;D:刪除
        /// </summary>
        public string FunctionZoneIson { get; set; } = null!;
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
    }
}
