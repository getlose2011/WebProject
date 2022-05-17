using System;
using System.Collections.Generic;

namespace WebProject.Modelsss
{
    public partial class Newsadmin
    {
        /// <summary>
        /// 帳號管理ID
        /// </summary>
        public int AdminId { get; set; }
        /// <summary>
        /// 帳號
        /// </summary>
        public string AdminUser { get; set; } = null!;
        /// <summary>
        /// 加鹽
        /// </summary>
        public string AdminSalt { get; set; } = null!;
        /// <summary>
        /// 管理者密碼
        /// </summary>
        public string AdminPassword { get; set; } = null!;
        /// <summary>
        /// 管理者姓名
        /// </summary>
        public string AdminName { get; set; } = null!;
        /// <summary>
        /// 管理者email
        /// </summary>
        public string AdminEmail { get; set; } = null!;
        /// <summary>
        /// 管理者電話
        /// </summary>
        public string AdminTel { get; set; } = null!;
        /// <summary>
        /// 管理者身份別1:管理者:admin , 2:主編:chief , 3:編輯:editor,4:作者
        /// </summary>
        public short AdminPower { get; set; }
        /// <summary>
        /// 管理者登入的IP
        /// </summary>
        public string AdminIp { get; set; } = null!;
        /// <summary>
        /// 管理者最後登入的時間
        /// </summary>
        public DateTime? AdminLastLoginTime { get; set; }
        /// <summary>
        /// D:刪除
        /// </summary>
        public string AdminIson { get; set; } = null!;
        public string AdminNote { get; set; } = null!;
        /// <summary>
        /// 管理者建立時間
        /// </summary>
        public DateTime CreateDate { get; set; }
        public DateTime ModifyDate { get; set; }
        /// <summary>
        /// 建立者
        /// </summary>
        public string CreateUser { get; set; } = null!;
        /// <summary>
        /// 管理者更新人員
        /// </summary>
        public string UpdateUser { get; set; } = null!;
        /// <summary>
        /// 新增者IP
        /// </summary>
        public string CreateIp { get; set; } = null!;
        /// <summary>
        /// 修改者IP
        /// </summary>
        public string UpdateIp { get; set; } = null!;
    }
}
