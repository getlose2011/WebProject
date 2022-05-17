using System;
using System.Collections.Generic;

namespace WebProject.Modelsss
{
    public partial class NewsvideoChanel
    {
        /// <summary>
        /// 節目影音ID
        /// </summary>
        public int ChanelId { get; set; }
        /// <summary>
        /// 節目影音清單呈現方式1:直接顯示所有節目的影音;2:另外設定多個分類主題顯示影音
        /// </summary>
        public int ChanelKind { get; set; }
        /// <summary>
        /// 節目名稱
        /// </summary>
        public string ChanelName { get; set; } = null!;
        /// <summary>
        /// 前台「影音」預設顯示數量
        /// 6 : 12
        /// </summary>
        public int ChanelFrontsum { get; set; }
        /// <summary>
        /// 影片來源型態1.youtube頻道、2.yt播放清單 
        /// </summary>
        public int? ChanelYturlKind { get; set; }
        /// <summary>
        /// 節目YT網址
        /// </summary>
        public string? ChanelYturl { get; set; }
        /// <summary>
        /// YouTube頻道ID/播放清單ID
        /// </summary>
        public string? ChanelUname { get; set; }
        /// <summary>
        /// 精彩節目首頁延伸網址
        /// </summary>
        public string? ChanelExUrl { get; set; }
        /// <summary>
        /// 精彩節目首頁延伸按鈕名稱
        /// </summary>
        public string? ChanelExName { get; set; }
        /// <summary>
        /// 節目簡介
        /// </summary>
        public string? ChanelDesc { get; set; }
        /// <summary>
        /// 節目圖片
        /// </summary>
        public string? ChanelImg { get; set; }
        /// <summary>
        /// 節目排序
        /// </summary>
        public int ChanelSort { get; set; }
        /// <summary>
        /// Y:啟用;N:不啟用;D:刪除
        /// </summary>
        public string ChanelIson { get; set; } = null!;
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
        /// <summary>
        /// 更新者IP
        /// </summary>
        public string UpdateIp { get; set; } = null!;
        /// <summary>
        /// 新增者
        /// </summary>
        public string CreateUser { get; set; } = null!;
        /// <summary>
        /// 新增者IP
        /// </summary>
        public string CreateIp { get; set; } = null!;
    }
}
