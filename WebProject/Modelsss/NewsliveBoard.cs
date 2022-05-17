using System;
using System.Collections.Generic;

namespace WebProject.Modelsss
{
    public partial class NewsliveBoard
    {
        /// <summary>
        /// 直播留言板開關設定ID
        /// </summary>
        public int LiveBoardId { get; set; }
        /// <summary>
        /// 開始日期
        /// </summary>
        public DateTime LiveBoardBegdate { get; set; }
        /// <summary>
        /// 結束日期
        /// </summary>
        public DateTime LiveBoardEnddate { get; set; }
        /// <summary>
        /// 開始時間
        /// </summary>
        public TimeSpan LiveBoardBegtime { get; set; }
        /// <summary>
        /// 結束時間
        /// </summary>
        public TimeSpan LiveBoardEndtime { get; set; }
        /// <summary>
        /// 開放星期
        /// </summary>
        public string LiveBoardWeek { get; set; } = null!;
        /// <summary>
        /// 對應NEWSLIVELIST直播ID
        /// </summary>
        public int LiveId { get; set; }
    }
}
