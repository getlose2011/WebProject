using System;
using System.Collections.Generic;

namespace WebProject.Modelsss
{
    public partial class Newscategory
    {
        /// <summary>
        /// 分類類別ID
        /// </summary>
        public int CategoryId { get; set; }
        /// <summary>
        /// 類別中文名稱
        /// </summary>
        public string CategoryCname { get; set; } = null!;
        /// <summary>
        /// 英文名稱
        /// </summary>
        public string? CategoryEname { get; set; }
        /// <summary>
        /// 連結功能FUNCTIONLIST_ID
        /// </summary>
        public int CategoryFunctionId { get; set; }
        /// <summary>
        /// 排序
        /// </summary>
        public int CategorySort { get; set; }
        /// <summary>
        /// Y:啟用;N:不啟用;D:刪除
        /// </summary>
        public string CategoryIson { get; set; } = null!;
        /// <summary>
        /// 新增日期
        /// </summary>
        public DateTime CreateDate { get; set; }
        /// <summary>
        /// 修改日期
        /// </summary>
        public DateTime ModifyDate { get; set; }
        /// <summary>
        /// 更新者對應ADMIN_ID
        /// </summary>
        public string UpdateUser { get; set; } = null!;
        /// <summary>
        /// 底色色碼
        /// </summary>
        public string CategoryColor { get; set; } = null!;
    }
}
