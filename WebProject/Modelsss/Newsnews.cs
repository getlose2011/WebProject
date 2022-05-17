using System;
using System.Collections.Generic;

namespace WebProject.Modelsss
{
    public partial class Newsnews
    {
        /// <summary>
        /// 新聞ID
        /// </summary>
        public int NewsId { get; set; }
        /// <summary>
        /// 標題
        /// </summary>
        public string NewsSubject { get; set; } = null!;
        /// <summary>
        /// 短標題
        /// </summary>
        public string? NewsSubjectShort { get; set; }
        /// <summary>
        /// 摘要
        /// </summary>
        public string NewsSummary { get; set; } = null!;
        /// <summary>
        /// 新聞內容
        /// </summary>
        public string NewsContents { get; set; } = null!;
        /// <summary>
        /// 圖片
        /// </summary>
        public string NewsImg { get; set; } = null!;
        /// <summary>
        /// 小圖
        /// </summary>
        public string NewsImgS { get; set; } = null!;
        /// <summary>
        /// RSS資料來源對應PARNER_ID
        /// </summary>
        public int NewsParnerId { get; set; }
        /// <summary>
        /// 主分類對應CATEGORY_ID
        /// </summary>
        public int NewsCategoryId { get; set; }
        /// <summary>
        /// 次分類對應CATEGORY_ID
        /// </summary>
        public string NewsCategoryIdSub { get; set; } = null!;
        /// <summary>
        /// 記者對應REPORTER_ID
        /// </summary>
        public int NewsReporterId { get; set; }
        /// <summary>
        /// 記者姓名
        /// </summary>
        public string NewsReporter { get; set; } = null!;
        /// <summary>
        /// Y:置頂;N:不置頂
        /// </summary>
        public string NewsTop { get; set; } = null!;
        /// <summary>
        /// iNews標題
        /// </summary>
        public string NewsInews { get; set; } = null!;
        /// <summary>
        /// FB Instant Articles啟用:Y;不啟用:N
        /// </summary>
        public string NewsFbia { get; set; } = null!;
        /// <summary>
        /// 相關新聞ID
        /// </summary>
        public string NewsNewsId { get; set; } = null!;
        /// <summary>
        /// 相關新聞關鍵字
        /// </summary>
        public string NewsKeyword { get; set; } = null!;
        /// <summary>
        /// 上線時間
        /// </summary>
        public DateTime NewsBegdate { get; set; }
        /// <summary>
        /// 限制18禁Y:啟用;N;不啟用
        /// </summary>
        public string NewsBan { get; set; } = null!;
        /// <summary>
        /// Y:啟用;N:不啟用;W:待審核;M:草稿;D:刪除;
        /// </summary>
        public string NewsIson { get; set; } = null!;
        /// <summary>
        /// 新增日期
        /// </summary>
        public DateTime CreateDate { get; set; }
        /// <summary>
        /// 新增者對應ADMIN_ID
        /// </summary>
        public string CreateUser { get; set; } = null!;
        /// <summary>
        /// 修改日期
        /// </summary>
        public DateTime ModifyDate { get; set; }
        /// <summary>
        /// 更新者對應ADMIN_ID
        /// </summary>
        public string UpdateUser { get; set; } = null!;
        /// <summary>
        /// 審核日期
        /// </summary>
        public DateTime? ApprovedDate { get; set; }
        /// <summary>
        /// 審核人員
        /// </summary>
        public string? ApprovedUser { get; set; }
        /// <summary>
        /// 1:旅遊美食;2:愛玩車;3:挑房趣
        /// </summary>
        public int? NewsOthernews { get; set; }
        /// <summary>
        /// YouTube影片網址
        /// </summary>
        public string NewsYoutube { get; set; } = null!;
        /// <summary>
        /// Facebook Video網址
        /// </summary>
        public string NewsFbvideo { get; set; } = null!;
        /// <summary>
        /// Embedded Code其它影片來源網址
        /// </summary>
        public string NewsOthervideo { get; set; } = null!;
        /// <summary>
        /// 同時新增為APP推播
        /// </summary>
        public string? NewsPushStatus { get; set; }
        /// <summary>
        ///  排程時間
        /// </summary>
        public DateTime? NewsPushDate { get; set; }
        /// <summary>
        /// 同時新增為WEB推播
        /// </summary>
        public string? NewsPushStatusWeb { get; set; }
        /// <summary>
        ///  排程時間
        /// </summary>
        public DateTime? NewsPushDateWeb { get; set; }
        /// <summary>
        /// 對應圖輯簿PIC_GROUP_ID
        /// </summary>
        public int PicGroupId { get; set; }
        /// <summary>
        /// Y:頭條新聞;N:無
        /// </summary>
        public string TodayTop { get; set; } = null!;
        /// <summary>
        /// 往下看更多新聞id
        /// </summary>
        public string MoreId { get; set; } = null!;
        /// <summary>
        /// 導購網址
        /// </summary>
        public string Buyurl { get; set; } = null!;
        /// <summary>
        /// Y:SOT新聞;N:否
        /// </summary>
        public string SotNews { get; set; } = null!;
        /// <summary>
        /// 內含影音(使用者在清單的圖片上會看到影片play的圖示)
        /// </summary>
        public string VideoNews { get; set; } = null!;
        /// <summary>
        /// 同時新增為快訊
        /// </summary>
        public string? NewsPushRealTime { get; set; }
        /// <summary>
        /// 上線時間
        /// </summary>
        public DateTime? NewsPushRealTimeOndate { get; set; }
        /// <summary>
        /// 下線時間
        /// </summary>
        public DateTime? NewsPushRealTimeOffDate { get; set; }
        /// <summary>
        /// 點閱次數
        /// </summary>
        public int? ClickCount { get; set; }
        /// <summary>
        /// 二稿
        /// </summary>
        public string NewsContents2 { get; set; } = null!;
        /// <summary>
        /// mp4 url
        /// </summary>
        public string? NewsVideoUrl { get; set; }
        /// <summary>
        /// 三稿(供索引與讀稿用)
        /// </summary>
        public string NewsContents3 { get; set; } = null!;
        /// <summary>
        /// Y:為業配文;N:否
        /// </summary>
        public string SponsorNews { get; set; } = null!;
        /// <summary>
        /// 圖片大小
        /// </summary>
        public int? ImgLength { get; set; }
        /// <summary>
        /// 熱門新聞,Y:要顯示;N:不要顯示
        /// </summary>
        public string HotNews { get; set; } = null!;
    }
}
