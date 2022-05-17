using System;
using System.Collections.Generic;

namespace WebProject.Modelsss
{
    public partial class Newsnewsvideo
    {
        /// <summary>
        /// 對應新聞NEWS_ID
        /// </summary>
        public int NewsvideoNewsId { get; set; }
        /// <summary>
        /// MP4上傳狀態Y:完成;N:否
        /// </summary>
        public string? NewsvideoIson { get; set; }
        /// <summary>
        /// 新增日期
        /// </summary>
        public DateTime CreateDate { get; set; }
    }
}
