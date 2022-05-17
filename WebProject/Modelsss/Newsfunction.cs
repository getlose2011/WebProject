using System;
using System.Collections.Generic;

namespace WebProject.Modelsss
{
    public partial class Newsfunction
    {
        /// <summary>
        /// 功能清單ID
        /// </summary>
        public int FunctionId { get; set; }
        /// <summary>
        /// 功能名稱
        /// </summary>
        public string FunctionName { get; set; } = null!;
        /// <summary>
        /// 圖片
        /// </summary>
        public string FunctionImg { get; set; } = null!;
        /// <summary>
        /// 功能版位
        /// </summary>
        public int FunctionZone { get; set; }
        /// <summary>
        /// 排序
        /// </summary>
        public int FunctionSort { get; set; }
        /// <summary>
        /// Y:啟用;N:不啟用;D:刪除
        /// </summary>
        public string FunctionIson { get; set; } = null!;
        /// <summary>
        /// 新增日期
        /// </summary>
        public DateTime CreateDate { get; set; }
        /// <summary>
        /// 修改日期
        /// </summary>
        public DateTime ModifyDate { get; set; }
        /// <summary>
        /// 更新者ADMIN_ID
        /// </summary>
        public string UpdateUser { get; set; } = null!;
    }
}
