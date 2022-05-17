using System;
using System.Collections.Generic;

namespace WebProject.Modelsss
{
    public partial class NewstopicKeyword
    {
        /// <summary>
        /// 對應TOPIC_ID
        /// </summary>
        public int TopicKeywordId { get; set; }
        /// <summary>
        /// 相關關鍵字
        /// </summary>
        public string TopicKeyword { get; set; } = null!;
    }
}
