using System;
using System.Collections.Generic;

namespace WebProject.Modelsss
{
    public partial class NewstopicSub
    {
        /// <summary>
        /// 對應TOPIC ID
        /// </summary>
        public int TopicsubId { get; set; }
        /// <summary>
        /// 對應新聞NEWS_ID
        /// </summary>
        public int TopicsubNewsId { get; set; }
        /// <summary>
        /// 前台呈現位置
        /// 0:不指定,則照新增日期排序
        /// 1:左大圖
        /// 2:右1
        /// 3:右2
        /// 4:右3
        /// </summary>
        public int TopicsubSort { get; set; }
    }
}
