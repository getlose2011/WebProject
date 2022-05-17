using System;
using System.Collections.Generic;

namespace WebProject.Modelsss
{
    public partial class NewsApp
    {
        public int NewsAppId { get; set; }
        /// <summary>
        /// iOS,Android
        /// </summary>
        public string System { get; set; } = null!;
        /// <summary>
        /// 版本名稱(如 4.0.1)
        /// </summary>
        public string VersionName { get; set; } = null!;
        /// <summary>
        /// 版本編號(如 58)
        /// </summary>
        public string VersionCode { get; set; } = null!;
        /// <summary>
        /// 是否出現建議更新提示(Y or N)
        /// </summary>
        public string ShowPrompt { get; set; } = null!;
        /// <summary>
        /// 是否強制要求更新提示(Y or N，若此屬性為Y，show_prompt必須為Y)
        /// </summary>
        public string ForcedUpdate { get; set; } = null!;
        public DateTime CreateDate { get; set; }
    }
}
