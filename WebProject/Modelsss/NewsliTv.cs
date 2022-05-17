using System;
using System.Collections.Generic;

namespace WebProject.Modelsss
{
    public partial class NewsliTv
    {
        /// <summary>
        /// LiTV影片ID
        /// </summary>
        public int LiTvId { get; set; }
        /// <summary>
        /// 對應NEWSLIVEmange資料表LIVEm_ID 直播管理ID 欄位
        /// </summary>
        public int LiTvLivemId { get; set; }
        /// <summary>
        /// 1:置換LiTV;2:不換LiTV
        /// </summary>
        public int LiTvType { get; set; }
        /// <summary>
        /// 單元 (Titile) 
        /// </summary>
        public string LiTvTitile { get; set; } = null!;
        /// <summary>
        /// 標題 (Subtitle)
        /// </summary>
        public string LiTvSubtitle { get; set; } = null!;
        /// <summary>
        /// 集數 (episode)
        /// </summary>
        public string LiTvEpisode { get; set; } = null!;
        /// <summary>
        /// 廣告值 (midroll)
        /// </summary>
        public string LiTvMidroll { get; set; } = null!;
        /// <summary>
        /// MP4上傳狀態Y:完成;N:否
        /// </summary>
        public string LiTvVideoIson { get; set; } = null!;
        /// <summary>
        /// JSON是否修改Y:是;N:否
        /// </summary>
        public string LiTvJsonIson { get; set; } = null!;
    }
}
