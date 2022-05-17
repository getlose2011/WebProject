using System;
using System.Collections.Generic;

namespace WebProject.Modelsss
{
    public partial class Newsvoice
    {
        /// <summary>
        /// 對應新聞NEWS_ID
        /// </summary>
        public int VoiceNewsId { get; set; }
        /// <summary>
        /// MP3上傳狀態Y:完成;N:否
        /// </summary>
        public string? VoiceIson { get; set; }
        /// <summary>
        /// 新增日期
        /// </summary>
        public DateTime CreateDate { get; set; }
    }
}
