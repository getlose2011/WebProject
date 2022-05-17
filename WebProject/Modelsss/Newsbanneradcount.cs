using System;
using System.Collections.Generic;

namespace WebProject.Modelsss
{
    public partial class Newsbanneradcount
    {
        /// <summary>
        /// banner曝光點擊紀錄ID
        /// </summary>
        public decimal AdcountId { get; set; }
        /// <summary>
        /// 對應BANNER_ID
        /// </summary>
        public int AdcountBannerId { get; set; }
        /// <summary>
        /// 1:曝光;2:點擊
        /// </summary>
        public int AdcountKind { get; set; }
        /// <summary>
        /// 新增日期
        /// </summary>
        public DateTime AdcountDate { get; set; }
        /// <summary>
        /// MACIP
        /// </summary>
        public string AdcountMacip { get; set; } = null!;
        /// <summary>
        /// 有登入的會員帳號
        /// </summary>
        public string? AdcountMemberId { get; set; }
    }
}
