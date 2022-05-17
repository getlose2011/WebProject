using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace WebProject.Modelsss
{
    public partial class EBCNEWSContext : DbContext
    {
        public EBCNEWSContext()
        {
        }

        public EBCNEWSContext(DbContextOptions<EBCNEWSContext> options)
            : base(options)
        {
        }

        public virtual DbSet<NewsApp> NewsApps { get; set; } = null!;
        public virtual DbSet<NewsInSubcategory> NewsInSubcategories { get; set; } = null!;
        public virtual DbSet<Newsact> Newsacts { get; set; } = null!;
        public virtual DbSet<NewsactKeyword> NewsactKeywords { get; set; } = null!;
        public virtual DbSet<NewsactSub> NewsactSubs { get; set; } = null!;
        public virtual DbSet<Newsadmin> Newsadmins { get; set; } = null!;
        public virtual DbSet<Newsbanner> Newsbanners { get; set; } = null!;
        public virtual DbSet<NewsbannerZone> NewsbannerZones { get; set; } = null!;
        public virtual DbSet<Newsbanneradcount> Newsbanneradcounts { get; set; } = null!;
        public virtual DbSet<Newscategory> Newscategories { get; set; } = null!;
        public virtual DbSet<Newsdfp> Newsdfps { get; set; } = null!;
        public virtual DbSet<Newsfunction> Newsfunctions { get; set; } = null!;
        public virtual DbSet<NewsfunctionZone> NewsfunctionZones { get; set; } = null!;
        public virtual DbSet<NewsliTv> NewsliTvs { get; set; } = null!;
        public virtual DbSet<NewsliveBoard> NewsliveBoards { get; set; } = null!;
        public virtual DbSet<Newslivelist> Newslivelists { get; set; } = null!;
        public virtual DbSet<Newslivemange> Newslivemanges { get; set; } = null!;
        public virtual DbSet<Newsnews> Newsnews { get; set; } = null!;
        public virtual DbSet<NewsnewsAmp> NewsnewsAmps { get; set; } = null!;
        public virtual DbSet<NewsnewsDiff> NewsnewsDiffs { get; set; } = null!;
        public virtual DbSet<Newsnewsvideo> Newsnewsvideos { get; set; } = null!;
        public virtual DbSet<Newspartner> Newspartners { get; set; } = null!;
        public virtual DbSet<NewspartnerNews> NewspartnerNews { get; set; } = null!;
        public virtual DbSet<Newspic> Newspics { get; set; } = null!;
        public virtual DbSet<NewspicGroup> NewspicGroups { get; set; } = null!;
        public virtual DbSet<Newspush> Newspushes { get; set; } = null!;
        public virtual DbSet<NewspushWeb> NewspushWebs { get; set; } = null!;
        public virtual DbSet<NewspushWebKey> NewspushWebKeys { get; set; } = null!;
        public virtual DbSet<Newsrealtimenews> Newsrealtimenews { get; set; } = null!;
        public virtual DbSet<Newstopic> Newstopics { get; set; } = null!;
        public virtual DbSet<NewstopicKeyword> NewstopicKeywords { get; set; } = null!;
        public virtual DbSet<NewstopicSub> NewstopicSubs { get; set; } = null!;
        public virtual DbSet<NewsuserReport> NewsuserReports { get; set; } = null!;
        public virtual DbSet<NewsvideoChanel> NewsvideoChanels { get; set; } = null!;
        public virtual DbSet<NewsvideoTopic> NewsvideoTopics { get; set; } = null!;
        public virtual DbSet<Newsvoice> Newsvoices { get; set; } = null!;
        public virtual DbSet<Newsyoutube> Newsyoutubes { get; set; } = null!;
        public virtual DbSet<NewsyoutubeLatest> NewsyoutubeLatests { get; set; } = null!;
        public virtual DbSet<Newsyoutubeviewct> Newsyoutubeviewcts { get; set; } = null!;
        public virtual DbSet<TrCategory> TrCategories { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning 
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<NewsApp>(entity =>
            {
                entity.ToTable("NEWS_APP");

                entity.Property(e => e.NewsAppId).HasColumnName("news_app_id");

                entity.Property(e => e.CreateDate)
                    .HasColumnType("datetime")
                    .HasColumnName("create_date")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.ForcedUpdate)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("forced_update")
                    .IsFixedLength()
                    .HasComment("是否強制要求更新提示(Y or N，若此屬性為Y，show_prompt必須為Y)");

                entity.Property(e => e.ShowPrompt)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("show_prompt")
                    .IsFixedLength()
                    .HasComment("是否出現建議更新提示(Y or N)");

                entity.Property(e => e.System)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("system")
                    .HasComment("iOS,Android");

                entity.Property(e => e.VersionCode)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("version_code")
                    .HasComment("版本編號(如 58)");

                entity.Property(e => e.VersionName)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("version_name")
                    .HasComment("版本名稱(如 4.0.1)");
            });

            modelBuilder.Entity<NewsInSubcategory>(entity =>
            {
                entity.HasKey(e => new { e.NewsId, e.NewsCategoryIdSub })
                    .HasName("PK_NEWS_SUBCATEGORY");

                entity.ToTable("NEWS_IN_SUBCATEGORY");

                entity.HasIndex(e => new { e.NewsCategoryIdSub, e.NewsId }, "NonClusteredIndex-20180810-171656");

                entity.Property(e => e.NewsId).HasColumnName("NEWS_ID");

                entity.Property(e => e.NewsCategoryIdSub).HasColumnName("NEWS_CATEGORY_ID_SUB");
            });

            modelBuilder.Entity<Newsact>(entity =>
            {
                entity.HasKey(e => e.ActId);

                entity.ToTable("NEWSACT");

                entity.Property(e => e.ActId)
                    .HasColumnName("ACT_ID")
                    .HasComment("活動管理ID");

                entity.Property(e => e.ActBegdate)
                    .HasColumnType("datetime")
                    .HasColumnName("ACT_BEGDATE")
                    .HasComment("上線時間");

                entity.Property(e => e.ActEnddate)
                    .HasColumnType("datetime")
                    .HasColumnName("ACT_ENDDATE")
                    .HasDefaultValueSql("('9999-12-31 23:59:59')");

                entity.Property(e => e.ActImg)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("ACT_IMG")
                    .HasDefaultValueSql("('')")
                    .HasComment("活動圖片(FOR APP)");

                entity.Property(e => e.ActIson)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("ACT_ISON")
                    .HasDefaultValueSql("('N')")
                    .IsFixedLength()
                    .HasComment("Y:啟用;N:不啟用;D:刪除");

                entity.Property(e => e.ActKeyword)
                    .HasMaxLength(100)
                    .HasColumnName("ACT_KEYWORD")
                    .HasDefaultValueSql("('')")
                    .HasComment("新聞關鍵字");

                entity.Property(e => e.ActKind)
                    .HasColumnName("ACT_KIND")
                    .HasComment("資料型態\r\n1:關鍵字文章\r\n2:外部連結");

                entity.Property(e => e.ActName)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("ACT_NAME")
                    .HasDefaultValueSql("('')")
                    .HasComment("活動名稱");

                entity.Property(e => e.ActRiderurl)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("ACT_RIDERURL")
                    .HasDefaultValueSql("('')")
                    .HasComment("導購網址");

                entity.Property(e => e.ActSort)
                    .HasColumnName("ACT_SORT")
                    .HasComment("活動排序");

                entity.Property(e => e.ActUrl)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("ACT_URL")
                    .HasDefaultValueSql("('')")
                    .HasComment("連結網址");

                entity.Property(e => e.CreateDate)
                    .HasColumnType("datetime")
                    .HasColumnName("CREATE_DATE")
                    .HasDefaultValueSql("(getdate())")
                    .HasComment("新增日期");

                entity.Property(e => e.CreateIp)
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasColumnName("CREATE_IP")
                    .HasDefaultValueSql("('')")
                    .HasComment("新增者IP");

                entity.Property(e => e.CreateUser)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("CREATE_USER")
                    .HasDefaultValueSql("('')")
                    .HasComment("新增者對應ADMIN_ID");

                entity.Property(e => e.ModifyDate)
                    .HasColumnType("datetime")
                    .HasColumnName("MODIFY_DATE")
                    .HasDefaultValueSql("(getdate())")
                    .HasComment("修改日期");

                entity.Property(e => e.UpdateIp)
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasColumnName("UPDATE_IP")
                    .HasDefaultValueSql("('')")
                    .HasComment("修改者IP");

                entity.Property(e => e.UpdateUser)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("UPDATE_USER")
                    .HasDefaultValueSql("('')")
                    .HasComment("更新者對應ADMIN_ID");
            });

            modelBuilder.Entity<NewsactKeyword>(entity =>
            {
                entity.HasKey(e => new { e.ActKeywordId, e.ActKeyword })
                    .HasName("PK_ACT_KEYWORD");

                entity.ToTable("NEWSACT_KEYWORD");

                entity.Property(e => e.ActKeywordId)
                    .HasColumnName("ACT_KEYWORD_ID")
                    .HasComment("對應ACT_ID");

                entity.Property(e => e.ActKeyword)
                    .HasMaxLength(50)
                    .HasColumnName("ACT_KEYWORD")
                    .HasDefaultValueSql("('')")
                    .HasComment("相關關鍵字");
            });

            modelBuilder.Entity<NewsactSub>(entity =>
            {
                entity.HasKey(e => new { e.ActsubId, e.ActsubNewsId });

                entity.ToTable("NEWSACT_SUB");

                entity.Property(e => e.ActsubId)
                    .HasColumnName("ACTSUB_ID")
                    .HasComment("對應ACT ID");

                entity.Property(e => e.ActsubNewsId)
                    .HasColumnName("ACTSUB_NEWS_ID")
                    .HasComment("對應新聞NEWS_ID");
            });

            modelBuilder.Entity<Newsadmin>(entity =>
            {
                entity.HasKey(e => e.AdminId);

                entity.ToTable("NEWSADMIN");

                entity.Property(e => e.AdminId)
                    .HasColumnName("ADMIN_ID")
                    .HasComment("帳號管理ID");

                entity.Property(e => e.AdminEmail)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("ADMIN_EMAIL")
                    .HasDefaultValueSql("('')")
                    .HasComment("管理者email");

                entity.Property(e => e.AdminIp)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("ADMIN_IP")
                    .HasDefaultValueSql("('')")
                    .HasComment("管理者登入的IP");

                entity.Property(e => e.AdminIson)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("ADMIN_ISON")
                    .IsFixedLength()
                    .HasComment("D:刪除");

                entity.Property(e => e.AdminLastLoginTime)
                    .HasColumnType("datetime")
                    .HasColumnName("ADMIN_LAST_LOGIN_TIME")
                    .HasComment("管理者最後登入的時間");

                entity.Property(e => e.AdminName)
                    .HasMaxLength(50)
                    .HasColumnName("ADMIN_NAME")
                    .HasComment("管理者姓名");

                entity.Property(e => e.AdminNote)
                    .HasMaxLength(100)
                    .HasColumnName("ADMIN_NOTE")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.AdminPassword)
                    .HasMaxLength(64)
                    .IsUnicode(false)
                    .HasColumnName("ADMIN_PASSWORD")
                    .HasComment("管理者密碼");

                entity.Property(e => e.AdminPower)
                    .HasColumnName("ADMIN_POWER")
                    .HasComment("管理者身份別1:管理者:admin , 2:主編:chief , 3:編輯:editor,4:作者");

                entity.Property(e => e.AdminSalt)
                    .HasMaxLength(36)
                    .IsUnicode(false)
                    .HasColumnName("ADMIN_SALT")
                    .HasComment("加鹽");

                entity.Property(e => e.AdminTel)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("ADMIN_TEL")
                    .HasDefaultValueSql("('')")
                    .HasComment("管理者電話");

                entity.Property(e => e.AdminUser)
                    .HasMaxLength(50)
                    .HasColumnName("ADMIN_USER")
                    .HasComment("帳號");

                entity.Property(e => e.CreateDate)
                    .HasColumnType("datetime")
                    .HasColumnName("CREATE_DATE")
                    .HasComment("管理者建立時間");

                entity.Property(e => e.CreateIp)
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasColumnName("CREATE_IP")
                    .HasDefaultValueSql("('')")
                    .HasComment("新增者IP");

                entity.Property(e => e.CreateUser)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("CREATE_USER")
                    .HasComment("建立者");

                entity.Property(e => e.ModifyDate)
                    .HasColumnType("datetime")
                    .HasColumnName("MODIFY_DATE");

                entity.Property(e => e.UpdateIp)
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasColumnName("UPDATE_IP")
                    .HasDefaultValueSql("('')")
                    .HasComment("修改者IP");

                entity.Property(e => e.UpdateUser)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("UPDATE_USER")
                    .HasComment("管理者更新人員");
            });

            modelBuilder.Entity<Newsbanner>(entity =>
            {
                entity.HasKey(e => e.BannerId)
                    .HasName("PK_BANNER");

                entity.ToTable("NEWSBANNER");

                entity.Property(e => e.BannerId)
                    .HasColumnName("BANNER_ID")
                    .HasComment("廣告ID");

                entity.Property(e => e.BannerBegdate)
                    .HasColumnType("datetime")
                    .HasColumnName("BANNER_BEGDATE")
                    .HasDefaultValueSql("(getdate())")
                    .HasComment("啟用日期");

                entity.Property(e => e.BannerClick)
                    .HasColumnName("BANNER_CLICK")
                    .HasComment("點擊值");

                entity.Property(e => e.BannerClicklimit)
                    .HasColumnName("BANNER_CLICKLIMIT")
                    .HasDefaultValueSql("('')")
                    .HasComment("觸擊次數(上限)");

                entity.Property(e => e.BannerEnddate)
                    .HasColumnType("datetime")
                    .HasColumnName("BANNER_ENDDATE")
                    .HasDefaultValueSql("(getdate())")
                    .HasComment("結束日期");

                entity.Property(e => e.BannerImg)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("BANNER_IMG")
                    .HasDefaultValueSql("('')")
                    .HasComment("廣告檔案");

                entity.Property(e => e.BannerIson)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("BANNER_ISON")
                    .HasDefaultValueSql("('Y')")
                    .IsFixedLength()
                    .HasComment("Y:啟用;N:不啟用;D:刪除");

                entity.Property(e => e.BannerKind)
                    .HasColumnName("BANNER_KIND")
                    .HasComment("對應NEWSFUNCTION_ID,目前原生廣告用FUNCTION_ZONE = 4");

                entity.Property(e => e.BannerName)
                    .HasMaxLength(200)
                    .HasColumnName("BANNER_NAME")
                    .HasDefaultValueSql("('')")
                    .HasComment("廣告名稱");

                entity.Property(e => e.BannerProperty)
                    .HasColumnName("BANNER_PROPERTY")
                    .HasComment("對應NEWSFUNCTION_ID,目前原生廣告用FUNCTION_ZONE = 5");

                entity.Property(e => e.BannerPv)
                    .HasColumnName("BANNER_PV")
                    .HasComment("曝光值");

                entity.Property(e => e.BannerPvlimit)
                    .HasColumnName("BANNER_PVLIMIT")
                    .HasDefaultValueSql("('')")
                    .HasComment("曝光次數(上限)");

                entity.Property(e => e.BannerSort)
                    .HasColumnName("BANNER_SORT")
                    .HasComment("排序");

                entity.Property(e => e.BannerSummary)
                    .HasMaxLength(200)
                    .HasColumnName("BANNER_SUMMARY")
                    .HasDefaultValueSql("('')")
                    .HasComment("廣告摘要");

                entity.Property(e => e.BannerUrl)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("BANNER_URL")
                    .HasDefaultValueSql("('')")
                    .HasComment("廣告網址");

                entity.Property(e => e.BannerVender)
                    .HasMaxLength(500)
                    .HasColumnName("BANNER_VENDER")
                    .HasDefaultValueSql("('')")
                    .HasComment("廣告商");

                entity.Property(e => e.BannerVideo)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("BANNER_VIDEO")
                    .HasDefaultValueSql("('')")
                    .HasComment("影片");

                entity.Property(e => e.BannerZone)
                    .HasColumnName("BANNER_ZONE")
                    .HasComment("對應BANNER_ZONE_ID");

                entity.Property(e => e.CreateDate)
                    .HasColumnType("datetime")
                    .HasColumnName("CREATE_DATE")
                    .HasDefaultValueSql("(getdate())")
                    .HasComment("新增日期");

                entity.Property(e => e.ModifyDate)
                    .HasColumnType("datetime")
                    .HasColumnName("MODIFY_DATE")
                    .HasDefaultValueSql("(getdate())")
                    .HasComment("修改日期");

                entity.Property(e => e.UpdateUser)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("UPDATE_USER")
                    .HasDefaultValueSql("('')")
                    .HasComment("更新者");
            });

            modelBuilder.Entity<NewsbannerZone>(entity =>
            {
                entity.HasKey(e => e.BannerZoneId);

                entity.ToTable("NEWSBANNER_ZONE");

                entity.Property(e => e.BannerZoneId)
                    .HasColumnName("BANNER_ZONE_ID")
                    .HasComment("廣告版位ID");

                entity.Property(e => e.BannerZoneDesc)
                    .HasMaxLength(50)
                    .HasColumnName("BANNER_ZONE_DESC")
                    .HasDefaultValueSql("('')")
                    .HasComment("版位說明");

                entity.Property(e => e.BannerZoneIson)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("BANNER_ZONE_ISON")
                    .HasDefaultValueSql("('Y')")
                    .IsFixedLength()
                    .HasComment("Y:啟用;N:不啟用;D:刪除");

                entity.Property(e => e.BannerZoneKind)
                    .HasColumnName("BANNER_ZONE_KIND")
                    .HasComment("後台顯示用分類,對應NEWSFUNCTION_ID");

                entity.Property(e => e.BannerZoneKindFront)
                    .HasColumnName("BANNER_ZONE_KIND_FRONT")
                    .HasComment("前台顯示用分類,對應NEWSFUNCTION_ID");

                entity.Property(e => e.BannerZoneMap)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("BANNER_ZONE_MAP")
                    .HasDefaultValueSql("('')")
                    .HasComment("對應JSON欄位key");

                entity.Property(e => e.BannerZoneName)
                    .HasMaxLength(50)
                    .HasColumnName("BANNER_ZONE_NAME")
                    .HasDefaultValueSql("('')")
                    .HasComment("版位名稱");

                entity.Property(e => e.CreateDate)
                    .HasColumnType("datetime")
                    .HasColumnName("CREATE_DATE")
                    .HasDefaultValueSql("(getdate())")
                    .HasComment("新增日期");

                entity.Property(e => e.ModifyDate)
                    .HasColumnType("datetime")
                    .HasColumnName("MODIFY_DATE")
                    .HasDefaultValueSql("(getdate())")
                    .HasComment("修改日期");

                entity.Property(e => e.UpdateUser)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("UPDATE_USER")
                    .HasDefaultValueSql("('')")
                    .HasComment("修改者ADMIN_ID");
            });

            modelBuilder.Entity<Newsbanneradcount>(entity =>
            {
                entity.HasKey(e => e.AdcountId)
                    .HasName("PK_BANNERADCOUNT");

                entity.ToTable("NEWSBANNERADCOUNT");

                entity.Property(e => e.AdcountId)
                    .HasColumnType("numeric(18, 0)")
                    .ValueGeneratedOnAdd()
                    .HasColumnName("ADCOUNT_ID")
                    .HasComment("banner曝光點擊紀錄ID");

                entity.Property(e => e.AdcountBannerId)
                    .HasColumnName("ADCOUNT_BANNER_ID")
                    .HasComment("對應BANNER_ID");

                entity.Property(e => e.AdcountDate)
                    .HasColumnType("datetime")
                    .HasColumnName("ADCOUNT_DATE")
                    .HasDefaultValueSql("(getdate())")
                    .HasComment("新增日期");

                entity.Property(e => e.AdcountKind)
                    .HasColumnName("ADCOUNT_KIND")
                    .HasComment("1:曝光;2:點擊");

                entity.Property(e => e.AdcountMacip)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("ADCOUNT_MACIP")
                    .HasDefaultValueSql("('')")
                    .HasComment("MACIP");

                entity.Property(e => e.AdcountMemberId)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("ADCOUNT_MEMBER_ID")
                    .HasComment("有登入的會員帳號");
            });

            modelBuilder.Entity<Newscategory>(entity =>
            {
                entity.HasKey(e => e.CategoryId)
                    .HasName("PK_CATEGORY");

                entity.ToTable("NEWSCATEGORY");

                entity.HasIndex(e => e.CategoryIson, "NonClusteredIndex-20180620-171329");

                entity.Property(e => e.CategoryId)
                    .HasColumnName("CATEGORY_ID")
                    .HasComment("分類類別ID");

                entity.Property(e => e.CategoryCname)
                    .HasMaxLength(20)
                    .HasColumnName("CATEGORY_CNAME")
                    .HasDefaultValueSql("('')")
                    .HasComment("類別中文名稱");

                entity.Property(e => e.CategoryColor)
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .HasColumnName("CATEGORY_COLOR")
                    .HasDefaultValueSql("('ffffff')")
                    .IsFixedLength()
                    .HasComment("底色色碼");

                entity.Property(e => e.CategoryEname)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("CATEGORY_ENAME")
                    .HasDefaultValueSql("('')")
                    .HasComment("英文名稱");

                entity.Property(e => e.CategoryFunctionId)
                    .HasColumnName("CATEGORY_FUNCTION_ID")
                    .HasComment("連結功能FUNCTIONLIST_ID");

                entity.Property(e => e.CategoryIson)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("CATEGORY_ISON")
                    .HasDefaultValueSql("('Y')")
                    .IsFixedLength()
                    .HasComment("Y:啟用;N:不啟用;D:刪除");

                entity.Property(e => e.CategorySort)
                    .HasColumnName("CATEGORY_SORT")
                    .HasComment("排序");

                entity.Property(e => e.CreateDate)
                    .HasColumnType("datetime")
                    .HasColumnName("CREATE_DATE")
                    .HasDefaultValueSql("(getdate())")
                    .HasComment("新增日期");

                entity.Property(e => e.ModifyDate)
                    .HasColumnType("datetime")
                    .HasColumnName("MODIFY_DATE")
                    .HasDefaultValueSql("(getdate())")
                    .HasComment("修改日期");

                entity.Property(e => e.UpdateUser)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("UPDATE_USER")
                    .HasDefaultValueSql("('')")
                    .HasComment("更新者對應ADMIN_ID");
            });

            modelBuilder.Entity<Newsdfp>(entity =>
            {
                entity.HasKey(e => e.DfpId);

                entity.ToTable("NEWSDFP");

                entity.Property(e => e.DfpId).HasColumnName("DFP_ID");

                entity.Property(e => e.CategoryId)
                    .HasColumnName("CATEGORY_ID")
                    .HasComment("DFP對應新聞分類ID (對應NewsCategory)");

                entity.Property(e => e.ChanelId).HasColumnName("CHANEL_ID");

                entity.Property(e => e.CreateDate)
                    .HasColumnType("datetime")
                    .HasColumnName("CREATE_DATE")
                    .HasDefaultValueSql("(getdate())")
                    .HasComment("建立時間");

                entity.Property(e => e.DfpArea)
                    .HasColumnName("DFP_AREA")
                    .HasComment("DFP區域");

                entity.Property(e => e.DfpCode)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("DFP_CODE")
                    .HasComment("DFP代碼");

                entity.Property(e => e.DfpPlatform)
                    .HasColumnName("DFP_PLATFORM")
                    .HasComment("1:web 2:app");

                entity.Property(e => e.DfpSize)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("DFP_SIZE")
                    .HasComment("DFP SIZE");
            });

            modelBuilder.Entity<Newsfunction>(entity =>
            {
                entity.HasKey(e => e.FunctionId)
                    .HasName("PK_FUNCTIONLIST");

                entity.ToTable("NEWSFUNCTION");

                entity.Property(e => e.FunctionId)
                    .HasColumnName("FUNCTION_ID")
                    .HasComment("功能清單ID");

                entity.Property(e => e.CreateDate)
                    .HasColumnType("datetime")
                    .HasColumnName("CREATE_DATE")
                    .HasDefaultValueSql("(getdate())")
                    .HasComment("新增日期");

                entity.Property(e => e.FunctionImg)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("FUNCTION_IMG")
                    .HasDefaultValueSql("('')")
                    .HasComment("圖片");

                entity.Property(e => e.FunctionIson)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("FUNCTION_ISON")
                    .HasDefaultValueSql("('N')")
                    .IsFixedLength()
                    .HasComment("Y:啟用;N:不啟用;D:刪除");

                entity.Property(e => e.FunctionName)
                    .HasMaxLength(50)
                    .HasColumnName("FUNCTION_NAME")
                    .HasDefaultValueSql("('')")
                    .HasComment("功能名稱");

                entity.Property(e => e.FunctionSort)
                    .HasColumnName("FUNCTION_SORT")
                    .HasComment("排序");

                entity.Property(e => e.FunctionZone)
                    .HasColumnName("FUNCTION_ZONE")
                    .HasComment("功能版位");

                entity.Property(e => e.ModifyDate)
                    .HasColumnType("datetime")
                    .HasColumnName("MODIFY_DATE")
                    .HasDefaultValueSql("(getdate())")
                    .HasComment("修改日期");

                entity.Property(e => e.UpdateUser)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("UPDATE_USER")
                    .HasDefaultValueSql("('')")
                    .HasComment("更新者ADMIN_ID");
            });

            modelBuilder.Entity<NewsfunctionZone>(entity =>
            {
                entity.HasKey(e => e.FunctionZoneId)
                    .HasName("PK_NEWSFUNCTION_KIND");

                entity.ToTable("NEWSFUNCTION_ZONE");

                entity.Property(e => e.FunctionZoneId)
                    .HasColumnName("FUNCTION_ZONE_ID")
                    .HasComment("功能版位ID");

                entity.Property(e => e.CreateDate)
                    .HasColumnType("datetime")
                    .HasColumnName("CREATE_DATE")
                    .HasDefaultValueSql("(getdate())")
                    .HasComment("新增日期");

                entity.Property(e => e.FunctionZoneDesc)
                    .HasMaxLength(50)
                    .HasColumnName("FUNCTION_ZONE_DESC")
                    .HasDefaultValueSql("('')")
                    .HasComment("版位說明");

                entity.Property(e => e.FunctionZoneIson)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("FUNCTION_ZONE_ISON")
                    .HasDefaultValueSql("('Y')")
                    .IsFixedLength()
                    .HasComment("Y:啟用;N:不啟用;D:刪除");

                entity.Property(e => e.FunctionZoneName)
                    .HasMaxLength(50)
                    .HasColumnName("FUNCTION_ZONE_NAME")
                    .HasDefaultValueSql("('')")
                    .HasComment("功能版位名稱");

                entity.Property(e => e.ModifyDate)
                    .HasColumnType("datetime")
                    .HasColumnName("MODIFY_DATE")
                    .HasDefaultValueSql("(getdate())")
                    .HasComment("修改日期");

                entity.Property(e => e.UpdateUser)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("UPDATE_USER")
                    .HasDefaultValueSql("('')")
                    .HasComment("更新者");
            });

            modelBuilder.Entity<NewsliTv>(entity =>
            {
                entity.HasKey(e => e.LiTvId);

                entity.ToTable("NEWSLiTV");

                entity.Property(e => e.LiTvId)
                    .HasColumnName("LiTV_ID")
                    .HasComment("LiTV影片ID");

                entity.Property(e => e.LiTvEpisode)
                    .HasMaxLength(200)
                    .HasColumnName("LiTV_episode")
                    .HasDefaultValueSql("('')")
                    .HasComment("集數 (episode)");

                entity.Property(e => e.LiTvJsonIson)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("LiTV_JSON_ISON")
                    .HasDefaultValueSql("('N')")
                    .IsFixedLength()
                    .HasComment("JSON是否修改Y:是;N:否");

                entity.Property(e => e.LiTvLivemId)
                    .HasColumnName("LiTV_LIVEm_ID")
                    .HasComment("對應NEWSLIVEmange資料表LIVEm_ID 直播管理ID 欄位");

                entity.Property(e => e.LiTvMidroll)
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasColumnName("LiTV_midroll")
                    .HasDefaultValueSql("('')")
                    .HasComment("廣告值 (midroll)");

                entity.Property(e => e.LiTvSubtitle)
                    .HasMaxLength(200)
                    .HasColumnName("LiTV_Subtitle")
                    .HasDefaultValueSql("('')")
                    .HasComment("標題 (Subtitle)");

                entity.Property(e => e.LiTvTitile)
                    .HasMaxLength(200)
                    .HasColumnName("LiTV_Titile")
                    .HasDefaultValueSql("('')")
                    .HasComment("單元 (Titile) ");

                entity.Property(e => e.LiTvType)
                    .HasColumnName("LiTV_TYPE")
                    .HasComment("1:置換LiTV;2:不換LiTV");

                entity.Property(e => e.LiTvVideoIson)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("LiTV_VIDEO_ISON")
                    .HasDefaultValueSql("('N')")
                    .IsFixedLength()
                    .HasComment("MP4上傳狀態Y:完成;N:否");
            });

            modelBuilder.Entity<NewsliveBoard>(entity =>
            {
                entity.HasKey(e => e.LiveBoardId);

                entity.ToTable("NEWSLIVE_BOARD");

                entity.Property(e => e.LiveBoardId)
                    .HasColumnName("LIVE_BOARD_ID")
                    .HasComment("直播留言板開關設定ID");

                entity.Property(e => e.LiveBoardBegdate)
                    .HasColumnType("datetime")
                    .HasColumnName("LIVE_BOARD_BEGDATE")
                    .HasDefaultValueSql("(getdate())")
                    .HasComment("開始日期");

                entity.Property(e => e.LiveBoardBegtime)
                    .HasColumnName("LIVE_BOARD_BEGTIME")
                    .HasComment("開始時間");

                entity.Property(e => e.LiveBoardEnddate)
                    .HasColumnType("datetime")
                    .HasColumnName("LIVE_BOARD_ENDDATE")
                    .HasDefaultValueSql("('9999/12/31 23:59:59')")
                    .HasComment("結束日期");

                entity.Property(e => e.LiveBoardEndtime)
                    .HasColumnName("LIVE_BOARD_ENDTIME")
                    .HasDefaultValueSql("('23:59:59')")
                    .HasComment("結束時間");

                entity.Property(e => e.LiveBoardWeek)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("LIVE_BOARD_WEEK")
                    .HasDefaultValueSql("('')")
                    .HasComment("開放星期");

                entity.Property(e => e.LiveId)
                    .HasColumnName("LIVE_ID")
                    .HasComment("對應NEWSLIVELIST直播ID");
            });

            modelBuilder.Entity<Newslivelist>(entity =>
            {
                entity.HasKey(e => e.LiveId);

                entity.ToTable("NEWSLIVELIST");

                entity.Property(e => e.LiveId)
                    .HasColumnName("LIVE_ID")
                    .HasComment("直播清單ID");

                entity.Property(e => e.CreateDate)
                    .HasColumnType("datetime")
                    .HasColumnName("CREATE_DATE")
                    .HasDefaultValueSql("(getdate())")
                    .HasComment("新增日期");

                entity.Property(e => e.LiveBegdate)
                    .HasColumnType("datetime")
                    .HasColumnName("LIVE_BEGDATE")
                    .HasDefaultValueSql("(getdate())")
                    .HasComment("開始日期");

                entity.Property(e => e.LiveBegtime)
                    .HasColumnName("LIVE_BEGTIME")
                    .HasComment("啟用時間");

                entity.Property(e => e.LiveBoardIson)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("LIVE_BOARD_ISON")
                    .HasDefaultValueSql("('N')")
                    .IsFixedLength()
                    .HasComment("留言版Y:啟用(關聯NEWSLIVE_BOARD);N不啟用");

                entity.Property(e => e.LiveChanel)
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasColumnName("LIVE_CHANEL")
                    .HasDefaultValueSql("('')")
                    .HasComment("YT Uname");

                entity.Property(e => e.LiveDescription)
                    .HasColumnName("LIVE_DESCRIPTION")
                    .HasDefaultValueSql("('')")
                    .HasComment("Youtube描述");

                entity.Property(e => e.LiveEnddate)
                    .HasColumnType("datetime")
                    .HasColumnName("LIVE_ENDDATE")
                    .HasDefaultValueSql("('9999-12-31 23:59:59')")
                    .HasComment("結束日期");

                entity.Property(e => e.LiveEndtme)
                    .HasColumnName("LIVE_ENDTME")
                    .HasDefaultValueSql("('23:59:59')")
                    .HasComment("結束時間");

                entity.Property(e => e.LiveFb)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("LIVE_FB")
                    .HasDefaultValueSql("('')")
                    .HasComment("fb直播id");

                entity.Property(e => e.LiveImg)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("LIVE_IMG")
                    .HasDefaultValueSql("('')")
                    .HasComment("圖片");

                entity.Property(e => e.LiveIson)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("LIVE_ISON")
                    .HasDefaultValueSql("('N')")
                    .IsFixedLength()
                    .HasComment("Y:啟用;N:不啟用;D:刪除");

                entity.Property(e => e.LiveKind)
                    .HasColumnName("LIVE_KIND")
                    .HasComment("1:24小時直播連結;2:直播管理");

                entity.Property(e => e.LiveName)
                    .HasMaxLength(500)
                    .HasColumnName("LIVE_NAME")
                    .HasDefaultValueSql("('')")
                    .HasComment("直播名稱");

                entity.Property(e => e.LiveSort)
                    .HasColumnName("LIVE_SORT")
                    .HasComment("排序");

                entity.Property(e => e.LiveTop)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("LIVE_TOP")
                    .HasDefaultValueSql("('N')")
                    .IsFixedLength()
                    .HasComment("置頂Y:是;N;否");

                entity.Property(e => e.LiveUrl)
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasColumnName("LIVE_URL")
                    .HasDefaultValueSql("('')")
                    .HasComment("節目ID");

                entity.Property(e => e.LiveViewct)
                    .HasColumnType("numeric(20, 0)")
                    .HasColumnName("LIVE_VIEWCT")
                    .HasComment("瀏覽人數");

                entity.Property(e => e.LiveWeek)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("LIVE_WEEK")
                    .HasDefaultValueSql("('')")
                    .HasComment("開放星期");

                entity.Property(e => e.ModifyDate)
                    .HasColumnType("datetime")
                    .HasColumnName("MODIFY_DATE")
                    .HasDefaultValueSql("(getdate())")
                    .HasComment("更新日期");

                entity.Property(e => e.UpdateUser)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("UPDATE_USER")
                    .HasDefaultValueSql("('')")
                    .HasComment("更新者ADMIN_ID");
            });

            modelBuilder.Entity<Newslivemange>(entity =>
            {
                entity.HasKey(e => e.LivemId);

                entity.ToTable("NEWSLIVEmange");

                entity.Property(e => e.LivemId)
                    .HasColumnName("LIVEm_ID")
                    .HasComment("直播管理ID");

                entity.Property(e => e.CreateDate)
                    .HasColumnType("datetime")
                    .HasColumnName("CREATE_DATE")
                    .HasDefaultValueSql("(getdate())")
                    .HasComment("新增日期");

                entity.Property(e => e.CreateIp)
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .HasColumnName("CREATE_IP")
                    .HasDefaultValueSql("('')")
                    .HasComment("新增者IP");

                entity.Property(e => e.CreateUser)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("CREATE_USER")
                    .HasDefaultValueSql("('')")
                    .HasComment("新增者對應ADMIN_ID");

                entity.Property(e => e.LiveImg)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("LIVE_IMG")
                    .HasComment("直播管理圖片");

                entity.Property(e => e.LivemBegdate)
                    .HasColumnType("datetime")
                    .HasColumnName("LIVEm_BEGDATE")
                    .HasDefaultValueSql("(getdate())")
                    .HasComment("上架時間");

                entity.Property(e => e.LivemChannelCode)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("LIVEm_CHANNEL_CODE")
                    .HasDefaultValueSql("('')")
                    .HasComment("YouTube頻道ID");

                entity.Property(e => e.LivemCode)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("LIVEm_CODE")
                    .HasDefaultValueSql("('')")
                    .HasComment("YouTube節目直播ID");

                entity.Property(e => e.LivemExName)
                    .HasMaxLength(70)
                    .HasColumnName("LIVEm_EX_NAME")
                    .HasDefaultValueSql("('')")
                    .HasComment("導購延伸按鈕名稱");

                entity.Property(e => e.LivemExUrl)
                    .HasMaxLength(120)
                    .HasColumnName("LIVEm_EX_URL")
                    .HasDefaultValueSql("('')")
                    .HasComment("導購延伸網址");

                entity.Property(e => e.LivemFb)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("LIVEm_FB")
                    .HasDefaultValueSql("('')")
                    .HasComment("fb直播id");

                entity.Property(e => e.LivemIndex)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("LIVEm_INDEX")
                    .HasDefaultValueSql("('Y')")
                    .IsFixedLength()
                    .HasComment("Y:顯示首頁\r\nN:否");

                entity.Property(e => e.LivemInside)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("LIVEm_INSIDE")
                    .HasDefaultValueSql("('N')")
                    .IsFixedLength()
                    .HasComment("Y:顯示於文章內頁\r\nN:否");

                entity.Property(e => e.LivemIson)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("LIVEm_ISON")
                    .HasDefaultValueSql("('N')")
                    .IsFixedLength()
                    .HasComment("Y:啟用;N:不啟用;D:刪除");

                entity.Property(e => e.LivemName)
                    .HasMaxLength(50)
                    .HasColumnName("LIVEm_NAME")
                    .HasDefaultValueSql("('')")
                    .HasComment("影片名稱");

                entity.Property(e => e.LivemSort)
                    .HasColumnName("LIVEm_SORT")
                    .HasComment("排序");

                entity.Property(e => e.LivemViewct)
                    .HasColumnType("numeric(20, 0)")
                    .HasColumnName("LIVEm_VIEWCT")
                    .HasComment("瀏覽人數");

                entity.Property(e => e.ModifyDate)
                    .HasColumnType("datetime")
                    .HasColumnName("MODIFY_DATE")
                    .HasDefaultValueSql("(getdate())")
                    .HasComment("更新日期");

                entity.Property(e => e.UpdateIp)
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .HasColumnName("UPDATE_IP")
                    .HasDefaultValueSql("('')")
                    .HasComment("修改者IP");

                entity.Property(e => e.UpdateUser)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("UPDATE_USER")
                    .HasDefaultValueSql("('')")
                    .HasComment("更新者ADMIN_ID");
            });

            modelBuilder.Entity<Newsnews>(entity =>
            {
                entity.HasKey(e => e.NewsId);

                entity.ToTable("NEWSNEWS");

                entity.Property(e => e.NewsId)
                    .HasColumnName("NEWS_ID")
                    .HasComment("新聞ID");

                entity.Property(e => e.ApprovedDate)
                    .HasColumnType("datetime")
                    .HasColumnName("APPROVED_DATE")
                    .HasComment("審核日期");

                entity.Property(e => e.ApprovedUser)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("APPROVED_USER")
                    .HasDefaultValueSql("('')")
                    .HasComment("審核人員");

                entity.Property(e => e.Buyurl)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("BUYURL")
                    .HasDefaultValueSql("('')")
                    .HasComment("導購網址");

                entity.Property(e => e.ClickCount)
                    .HasDefaultValueSql("((0))")
                    .HasComment("點閱次數");

                entity.Property(e => e.CreateDate)
                    .HasColumnType("datetime")
                    .HasColumnName("CREATE_DATE")
                    .HasDefaultValueSql("(getdate())")
                    .HasComment("新增日期");

                entity.Property(e => e.CreateUser)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("CREATE_USER")
                    .HasDefaultValueSql("('')")
                    .HasComment("新增者對應ADMIN_ID");

                entity.Property(e => e.HotNews)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("HOT_NEWS")
                    .HasDefaultValueSql("('Y')")
                    .IsFixedLength()
                    .HasComment("熱門新聞,Y:要顯示;N:不要顯示");

                entity.Property(e => e.ImgLength).HasComment("圖片大小");

                entity.Property(e => e.ModifyDate)
                    .HasColumnType("datetime")
                    .HasColumnName("MODIFY_DATE")
                    .HasDefaultValueSql("(getdate())")
                    .HasComment("修改日期");

                entity.Property(e => e.MoreId)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("MORE_ID")
                    .HasDefaultValueSql("((0))")
                    .HasComment("往下看更多新聞id");

                entity.Property(e => e.NewsBan)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("NEWS_BAN")
                    .HasDefaultValueSql("('N')")
                    .IsFixedLength()
                    .HasComment("限制18禁Y:啟用;N;不啟用");

                entity.Property(e => e.NewsBegdate)
                    .HasColumnType("datetime")
                    .HasColumnName("NEWS_BEGDATE")
                    .HasDefaultValueSql("(getdate())")
                    .HasComment("上線時間");

                entity.Property(e => e.NewsCategoryId)
                    .HasColumnName("NEWS_CATEGORY_ID")
                    .HasComment("主分類對應CATEGORY_ID");

                entity.Property(e => e.NewsCategoryIdSub)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("NEWS_CATEGORY_ID_SUB")
                    .HasDefaultValueSql("('')")
                    .HasComment("次分類對應CATEGORY_ID");

                entity.Property(e => e.NewsContents)
                    .HasColumnName("NEWS_CONTENTS")
                    .HasDefaultValueSql("('')")
                    .HasComment("新聞內容");

                entity.Property(e => e.NewsContents2)
                    .HasColumnName("NEWS_CONTENTS_2")
                    .HasDefaultValueSql("('')")
                    .HasComment("二稿");

                entity.Property(e => e.NewsContents3)
                    .HasColumnName("NEWS_CONTENTS_3")
                    .HasDefaultValueSql("('')")
                    .HasComment("三稿(供索引與讀稿用)");

                entity.Property(e => e.NewsFbia)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("NEWS_FBIA")
                    .HasDefaultValueSql("('N')")
                    .IsFixedLength()
                    .HasComment("FB Instant Articles啟用:Y;不啟用:N");

                entity.Property(e => e.NewsFbvideo)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("NEWS_FBVIDEO")
                    .HasDefaultValueSql("('')")
                    .HasComment("Facebook Video網址");

                entity.Property(e => e.NewsImg)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("NEWS_IMG")
                    .HasDefaultValueSql("('')")
                    .HasComment("圖片");

                entity.Property(e => e.NewsImgS)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("NEWS_IMG_S")
                    .HasDefaultValueSql("('')")
                    .HasComment("小圖");

                entity.Property(e => e.NewsInews)
                    .HasMaxLength(300)
                    .HasColumnName("NEWS_INEWS")
                    .HasDefaultValueSql("('')")
                    .HasComment("iNews標題");

                entity.Property(e => e.NewsIson)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("NEWS_ISON")
                    .HasDefaultValueSql("('W')")
                    .IsFixedLength()
                    .HasComment("Y:啟用;N:不啟用;W:待審核;M:草稿;D:刪除;");

                entity.Property(e => e.NewsKeyword)
                    .HasMaxLength(150)
                    .HasColumnName("NEWS_KEYWORD")
                    .HasDefaultValueSql("('')")
                    .HasComment("相關新聞關鍵字");

                entity.Property(e => e.NewsNewsId)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("NEWS_NEWS_ID")
                    .HasDefaultValueSql("('')")
                    .HasComment("相關新聞ID");

                entity.Property(e => e.NewsOthernews)
                    .HasColumnName("NEWS_OTHERNEWS")
                    .HasDefaultValueSql("((0))")
                    .HasComment("1:旅遊美食;2:愛玩車;3:挑房趣");

                entity.Property(e => e.NewsOthervideo)
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasColumnName("NEWS_OTHERVIDEO")
                    .HasDefaultValueSql("('')")
                    .HasComment("Embedded Code其它影片來源網址");

                entity.Property(e => e.NewsParnerId)
                    .HasColumnName("NEWS_PARNER_ID")
                    .HasComment("RSS資料來源對應PARNER_ID");

                entity.Property(e => e.NewsPushDate)
                    .HasColumnType("datetime")
                    .HasColumnName("NEWS_PushDate")
                    .HasComment(" 排程時間");

                entity.Property(e => e.NewsPushDateWeb)
                    .HasColumnType("datetime")
                    .HasColumnName("NEWS_PushDate_web")
                    .HasComment(" 排程時間");

                entity.Property(e => e.NewsPushRealTime)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("NEWS_PushRealTime")
                    .IsFixedLength()
                    .HasComment("同時新增為快訊");

                entity.Property(e => e.NewsPushRealTimeOffDate)
                    .HasColumnType("datetime")
                    .HasColumnName("NEWS_PushRealTime_offDate")
                    .HasComment("下線時間");

                entity.Property(e => e.NewsPushRealTimeOndate)
                    .HasColumnType("datetime")
                    .HasColumnName("NEWS_PushRealTime_ondate")
                    .HasComment("上線時間");

                entity.Property(e => e.NewsPushStatus)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("NEWS_PushStatus")
                    .IsFixedLength()
                    .HasComment("同時新增為APP推播");

                entity.Property(e => e.NewsPushStatusWeb)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("NEWS_PushStatus_web")
                    .IsFixedLength()
                    .HasComment("同時新增為WEB推播");

                entity.Property(e => e.NewsReporter)
                    .HasMaxLength(80)
                    .HasColumnName("NEWS_REPORTER")
                    .HasDefaultValueSql("('')")
                    .HasComment("記者姓名");

                entity.Property(e => e.NewsReporterId)
                    .HasColumnName("NEWS_REPORTER_ID")
                    .HasComment("記者對應REPORTER_ID");

                entity.Property(e => e.NewsSubject)
                    .HasMaxLength(300)
                    .HasColumnName("NEWS_SUBJECT")
                    .HasDefaultValueSql("('')")
                    .HasComment("標題");

                entity.Property(e => e.NewsSubjectShort)
                    .HasMaxLength(15)
                    .HasColumnName("NEWS_SUBJECT_SHORT")
                    .HasDefaultValueSql("('')")
                    .HasComment("短標題");

                entity.Property(e => e.NewsSummary)
                    .HasMaxLength(300)
                    .HasColumnName("NEWS_SUMMARY")
                    .HasDefaultValueSql("('')")
                    .HasComment("摘要");

                entity.Property(e => e.NewsTop)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("NEWS_TOP")
                    .HasDefaultValueSql("('N')")
                    .IsFixedLength()
                    .HasComment("Y:置頂;N:不置頂");

                entity.Property(e => e.NewsVideoUrl)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("NEWS_VIDEO_URL")
                    .HasComment("mp4 url");

                entity.Property(e => e.NewsYoutube)
                    .HasMaxLength(50)
                    .HasColumnName("NEWS_YOUTUBE")
                    .HasDefaultValueSql("('')")
                    .HasComment("YouTube影片網址");

                entity.Property(e => e.PicGroupId)
                    .HasColumnName("PIC_GROUP_ID")
                    .HasComment("對應圖輯簿PIC_GROUP_ID");

                entity.Property(e => e.SotNews)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("SOT_NEWS")
                    .HasDefaultValueSql("('N')")
                    .IsFixedLength()
                    .HasComment("Y:SOT新聞;N:否");

                entity.Property(e => e.SponsorNews)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("SPONSOR_NEWS")
                    .HasDefaultValueSql("('N')")
                    .IsFixedLength()
                    .HasComment("Y:為業配文;N:否");

                entity.Property(e => e.TodayTop)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("TODAY_TOP")
                    .HasDefaultValueSql("('N')")
                    .IsFixedLength()
                    .HasComment("Y:頭條新聞;N:無");

                entity.Property(e => e.UpdateUser)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("UPDATE_USER")
                    .HasDefaultValueSql("('')")
                    .HasComment("更新者對應ADMIN_ID");

                entity.Property(e => e.VideoNews)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("VIDEO_NEWS")
                    .HasDefaultValueSql("('N')")
                    .IsFixedLength()
                    .HasComment("內含影音(使用者在清單的圖片上會看到影片play的圖示)");
            });

            modelBuilder.Entity<NewsnewsAmp>(entity =>
            {
                entity.HasKey(e => e.AmpId);

                entity.ToTable("NEWSNEWS_AMP");

                entity.HasIndex(e => e.NewsId, "IDX_NEWSNEWS_AMP_NEWS_ID_U")
                    .IsUnique();

                entity.Property(e => e.AmpId)
                    .HasColumnName("AMP_ID")
                    .HasComment("AMP新聞ID");

                entity.Property(e => e.NewsContentsAmp)
                    .HasColumnName("NEWS_CONTENTS_AMP")
                    .HasComment("AMP新聞內容");

                entity.Property(e => e.NewsId)
                    .HasColumnName("NEWS_ID")
                    .HasComment("新聞ID對應NEWSNEWS之NEWS_ID");
            });

            modelBuilder.Entity<NewsnewsDiff>(entity =>
            {
                entity.HasKey(e => e.Seqno);

                entity.ToTable("NEWSNEWS_DIFF");

                entity.Property(e => e.Seqno).HasColumnName("SEQNO");

                entity.Property(e => e.Mode).HasColumnName("MODE");

                entity.Property(e => e.NewsId).HasColumnName("NEWS_ID");
            });

            modelBuilder.Entity<Newsnewsvideo>(entity =>
            {
                entity.HasKey(e => e.NewsvideoNewsId);

                entity.ToTable("NEWSNEWSVIDEO");

                entity.Property(e => e.NewsvideoNewsId)
                    .ValueGeneratedNever()
                    .HasColumnName("NEWSVIDEO_NEWS_ID")
                    .HasComment("對應新聞NEWS_ID");

                entity.Property(e => e.CreateDate)
                    .HasColumnType("datetime")
                    .HasColumnName("CREATE_DATE")
                    .HasDefaultValueSql("(getdate())")
                    .HasComment("新增日期");

                entity.Property(e => e.NewsvideoIson)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("NEWSVIDEO_ISON")
                    .IsFixedLength()
                    .HasComment("MP4上傳狀態Y:完成;N:否");
            });

            modelBuilder.Entity<Newspartner>(entity =>
            {
                entity.HasKey(e => e.PartnerId);

                entity.ToTable("NEWSPARTNER");

                entity.Property(e => e.PartnerId)
                    .HasColumnName("PARTNER_ID")
                    .HasComment("合作夥伴管理ID");

                entity.Property(e => e.PartnerAuto)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("PARTNER_AUTO")
                    .HasDefaultValueSql("('2')")
                    .IsFixedLength()
                    .HasComment("2:須再點「匯入」的時候把rss資料帶到新增新聞的編輯區;1有新文章自動發佈到”已上線”");

                entity.Property(e => e.PartnerCategoryId)
                    .HasColumnName("PARTNER_CATEGORY_ID")
                    .HasComment("主分類對應CATEGORY_ID");

                entity.Property(e => e.PartnerCategoryIdSub)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("PARTNER_CATEGORY_ID_SUB")
                    .HasDefaultValueSql("((0))")
                    .IsFixedLength()
                    .HasComment("次分類對應CATEGORY_ID");

                entity.Property(e => e.PartnerCreterDate)
                    .HasColumnType("datetime")
                    .HasColumnName("PARTNER_CRETER_DATE")
                    .HasDefaultValueSql("(getdate())")
                    .HasComment("新增日期");

                entity.Property(e => e.PartnerCreterUser)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("PARTNER_CRETER_USER")
                    .HasDefaultValueSql("('')")
                    .HasComment("新增者");

                entity.Property(e => e.PartnerIson)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("PARTNER_ISON")
                    .HasDefaultValueSql("('N')")
                    .IsFixedLength()
                    .HasComment("Y:啟用;N:不啟用");

                entity.Property(e => e.PartnerLogo)
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasColumnName("PARTNER_LOGO")
                    .HasDefaultValueSql("('')")
                    .HasComment("LOGO");

                entity.Property(e => e.PartnerModifyDate)
                    .HasColumnType("datetime")
                    .HasColumnName("PARTNER_MODIFY_DATE")
                    .HasDefaultValueSql("(getdate())")
                    .HasComment("更新日期");

                entity.Property(e => e.PartnerName)
                    .HasMaxLength(50)
                    .HasColumnName("PARTNER_NAME")
                    .HasDefaultValueSql("('')")
                    .HasComment("夥伴名稱");

                entity.Property(e => e.PartnerOthernews)
                    .HasColumnName("PARTNER_OTHERNEWS")
                    .HasComment("新聞類型(1:旅遊美食;2:愛玩車)");

                entity.Property(e => e.PartnerRss)
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasColumnName("PARTNER_RSS")
                    .HasDefaultValueSql("('')")
                    .HasComment("RSS網址");

                entity.Property(e => e.PartnerUpdateUser)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("PARTNER_UPDATE_USER")
                    .HasDefaultValueSql("('')")
                    .HasComment("更新者");

                entity.Property(e => e.PartnerUrl)
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasColumnName("PARTNER_URL")
                    .HasDefaultValueSql("('')")
                    .HasComment("夥伴網址");
            });

            modelBuilder.Entity<NewspartnerNews>(entity =>
            {
                entity.HasKey(e => e.PnnewsId);

                entity.ToTable("NEWSPARTNER_NEWS");

                entity.Property(e => e.PnnewsId)
                    .HasColumnName("PNNEWS_ID")
                    .HasComment("合作夥伴管理新聞紀錄ID");

                entity.Property(e => e.PnnewsCategoryId)
                    .HasColumnName("PNNEWS_CATEGORY_ID")
                    .HasComment("主分類對應CATEGORY_ID");

                entity.Property(e => e.PnnewsCategoryIdSub)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("PNNEWS_CATEGORY_ID_SUB")
                    .HasDefaultValueSql("((0))")
                    .IsFixedLength()
                    .HasComment("次分類對應CATEGORY_ID");

                entity.Property(e => e.PnnewsContents)
                    .HasColumnName("PNNEWS_CONTENTS")
                    .HasDefaultValueSql("('')")
                    .HasComment("新聞內容");

                entity.Property(e => e.PnnewsCretaeTime)
                    .HasColumnType("datetime")
                    .HasColumnName("PNNEWS_CRETAE_TIME")
                    .HasDefaultValueSql("(getdate())")
                    .HasComment("RSS資料匯入時間");

                entity.Property(e => e.PnnewsEmbedVideo)
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasColumnName("PNNEWS_EMBED_VIDEO")
                    .HasComment("紀錄rss embed tag 裡的YouTube影片網址");

                entity.Property(e => e.PnnewsGuid)
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasColumnName("PNNEWS_GUID")
                    .HasDefaultValueSql("('')")
                    .HasComment("紀錄來源guid");

                entity.Property(e => e.PnnewsImg)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("PNNEWS_IMG")
                    .HasDefaultValueSql("('')")
                    .HasComment("封面圖片");

                entity.Property(e => e.PnnewsNewsLink)
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasColumnName("PNNEWS_NEWS_LINK")
                    .HasDefaultValueSql("('')")
                    .HasComment("紀錄來源新聞網址");

                entity.Property(e => e.PnnewsNote)
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasColumnName("PNNEWS_NOTE");

                entity.Property(e => e.PnnewsOthernews)
                    .HasColumnName("PNNEWS_OTHERNEWS")
                    .HasComment("新聞類型(1:旅遊美食;2:愛玩車)");

                entity.Property(e => e.PnnewsPartnerId)
                    .HasColumnName("PNNEWS_PARTNER_ID")
                    .HasDefaultValueSql("('')")
                    .HasComment("對應PARNER_ID");

                entity.Property(e => e.PnnewsReporter)
                    .HasMaxLength(200)
                    .HasColumnName("PNNEWS_REPORTER")
                    .HasDefaultValueSql("('')")
                    .HasComment("記者姓名");

                entity.Property(e => e.PnnewsSubject)
                    .HasMaxLength(200)
                    .HasColumnName("PNNEWS_SUBJECT")
                    .HasDefaultValueSql("('')")
                    .HasComment("主旨標題");

                entity.Property(e => e.PnnewsSummary)
                    .HasMaxLength(200)
                    .HasColumnName("PNNEWS_SUMMARY")
                    .HasDefaultValueSql("('')")
                    .HasComment("摘要");

                entity.Property(e => e.PnnewsUpdateTime)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("PNNEWS_UPDATE_TIME")
                    .HasDefaultValueSql("('')")
                    .HasComment("匯入到新增新聞table時間");

                entity.Property(e => e.PnnewsUpdater)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("PNNEWS_UPDATER")
                    .HasDefaultValueSql("('')")
                    .HasComment("更新者");
            });

            modelBuilder.Entity<Newspic>(entity =>
            {
                entity.HasKey(e => e.PicId);

                entity.ToTable("NEWSPIC");

                entity.Property(e => e.PicId)
                    .HasColumnName("PIC_ID")
                    .HasComment("圖輯相片ID");

                entity.Property(e => e.CreateDate)
                    .HasColumnType("datetime")
                    .HasColumnName("CREATE_DATE")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.CreateIp)
                    .IsUnicode(false)
                    .HasColumnName("CREATE_IP")
                    .HasDefaultValueSql("('')")
                    .HasComment("新增者IP");

                entity.Property(e => e.ModifyDate)
                    .HasColumnType("datetime")
                    .HasColumnName("MODIFY_DATE")
                    .HasDefaultValueSql("(getdate())")
                    .HasComment("修改日期");

                entity.Property(e => e.PicFilename)
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasColumnName("PIC_FILENAME")
                    .HasDefaultValueSql("('')")
                    .HasComment("檔案名稱");

                entity.Property(e => e.PicFilesize)
                    .HasColumnName("PIC_FILESIZE")
                    .HasComment("檔案大小");

                entity.Property(e => e.PicGroupId)
                    .HasColumnName("PIC_GROUP_ID")
                    .HasComment("對應圖輯簿PIC_GROUP_ID");

                entity.Property(e => e.PicIson)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("PIC_ISON")
                    .HasDefaultValueSql("('Y')")
                    .IsFixedLength()
                    .HasComment("Y:顯示;N:不顯示;D:刪除");

                entity.Property(e => e.UpdateIp)
                    .IsUnicode(false)
                    .HasColumnName("UPDATE_IP")
                    .HasDefaultValueSql("('')")
                    .HasComment("修改者IP");
            });

            modelBuilder.Entity<NewspicGroup>(entity =>
            {
                entity.HasKey(e => e.PicGroupId);

                entity.ToTable("NEWSPIC_GROUP");

                entity.Property(e => e.PicGroupId)
                    .HasColumnName("PIC_GROUP_ID")
                    .HasComment("圖輯簿ID");

                entity.Property(e => e.CreateDate)
                    .HasColumnType("datetime")
                    .HasColumnName("CREATE_DATE")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.CreateIp)
                    .IsUnicode(false)
                    .HasColumnName("CREATE_IP")
                    .HasDefaultValueSql("('')")
                    .HasComment("新增者IP");

                entity.Property(e => e.ModifyDate)
                    .HasColumnType("datetime")
                    .HasColumnName("MODIFY_DATE")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.PicGroupIson)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("PIC_GROUP_ISON")
                    .HasDefaultValueSql("('Y')")
                    .IsFixedLength()
                    .HasComment("Y:顯示;N:不顯示;D:刪除");

                entity.Property(e => e.PicGroupName)
                    .HasMaxLength(50)
                    .HasColumnName("PIC_GROUP_NAME")
                    .HasDefaultValueSql("('')")
                    .HasComment("圖輯名稱");

                entity.Property(e => e.UpdateIp)
                    .IsUnicode(false)
                    .HasColumnName("UPDATE_IP")
                    .HasDefaultValueSql("('')")
                    .HasComment("更新者IP");

                entity.Property(e => e.UpdateUser)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("UPDATE_USER")
                    .HasDefaultValueSql("('')")
                    .HasComment("更新者對應ADMIN_ID");
            });

            modelBuilder.Entity<Newspush>(entity =>
            {
                entity.HasKey(e => e.PushId);

                entity.ToTable("NEWSPUSH");

                entity.Property(e => e.PushId).HasColumnName("PUSH_ID");

                entity.Property(e => e.PushAws)
                    .HasColumnName("PUSH_AWS")
                    .HasComment("是否推送成功 1:已推播 0:未推播");

                entity.Property(e => e.PushCreateDate)
                    .HasColumnType("datetime")
                    .HasColumnName("PUSH_CREATE_DATE")
                    .HasDefaultValueSql("(getdate())")
                    .HasComment("新增日期");

                entity.Property(e => e.PushDatetime)
                    .HasColumnType("datetime")
                    .HasColumnName("PUSH_DATETIME")
                    .HasDefaultValueSql("(getdate())")
                    .HasComment("排程時間");

                entity.Property(e => e.PushIson)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("PUSH_ISON")
                    .HasDefaultValueSql("('N')")
                    .IsFixedLength()
                    .HasComment("Y:已經發送;N:未發送;D:刪除");

                entity.Property(e => e.PushModifyDate)
                    .HasColumnType("datetime")
                    .HasColumnName("PUSH_MODIFY_DATE")
                    .HasDefaultValueSql("(getdate())")
                    .HasComment("修改日期");

                entity.Property(e => e.PushNewsId)
                    .HasColumnName("PUSH_NEWS_ID")
                    .HasDefaultValueSql("((0))")
                    .HasComment("新聞ID");

                entity.Property(e => e.PushTitle)
                    .HasMaxLength(60)
                    .HasColumnName("PUSH_TITLE")
                    .HasDefaultValueSql("('')")
                    .HasComment("標題");

                entity.Property(e => e.PushUrl)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("PUSH_URL")
                    .HasComment("('')");

                entity.Property(e => e.UpdateUser)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("UPDATE_USER")
                    .HasDefaultValueSql("('')")
                    .HasComment("更新者");
            });

            modelBuilder.Entity<NewspushWeb>(entity =>
            {
                entity.HasKey(e => e.PushwebId);

                entity.ToTable("NEWSPUSH_WEB");

                entity.Property(e => e.PushwebId)
                    .HasColumnName("PUSHWEB_ID")
                    .HasComment("Web瀏覽器推播通知ID");

                entity.Property(e => e.PushwebCreateDate)
                    .HasColumnType("datetime")
                    .HasColumnName("PUSHWEB_CREATE_DATE")
                    .HasDefaultValueSql("(getdate())")
                    .HasComment("新增日期");

                entity.Property(e => e.PushwebDatetime)
                    .HasColumnType("datetime")
                    .HasColumnName("PUSHWEB_DATETIME")
                    .HasDefaultValueSql("(getdate())")
                    .HasComment("排程時間");

                entity.Property(e => e.PushwebFirebase)
                    .HasColumnName("PUSHWEB_firebase")
                    .HasComment("是否推送成功 1:已推播 0:未推播");

                entity.Property(e => e.PushwebIson)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("PUSHWEB_ISON")
                    .HasDefaultValueSql("('N')")
                    .IsFixedLength()
                    .HasComment("Y:已經發送;N:未發送;D:刪除");

                entity.Property(e => e.PushwebModifyDate)
                    .HasColumnType("datetime")
                    .HasColumnName("PUSHWEB_MODIFY_DATE")
                    .HasDefaultValueSql("(getdate())")
                    .HasComment("修改日期");

                entity.Property(e => e.PushwebNewsId)
                    .HasColumnName("PUSHWEB_NEWS_ID")
                    .HasDefaultValueSql("((0))")
                    .HasComment("新聞ID");

                entity.Property(e => e.PushwebTitle)
                    .HasMaxLength(150)
                    .HasColumnName("PUSHWEB_TITLE")
                    .HasDefaultValueSql("('')")
                    .HasComment("標題");

                entity.Property(e => e.PushwebUrl)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("PUSHWEB_URL")
                    .HasComment("('')");

                entity.Property(e => e.UpdateUser)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("UPDATE_USER")
                    .HasDefaultValueSql("('')")
                    .HasComment("更新者");
            });

            modelBuilder.Entity<NewspushWebKey>(entity =>
            {
                entity.HasKey(e => e.WebpushId);

                entity.ToTable("NEWSPUSH_WEB_KEY");

                entity.Property(e => e.WebpushId)
                    .HasColumnName("WEBPUSH_ID")
                    .HasComment("存放web推播client key值ID");

                entity.Property(e => e.CreateDate)
                    .HasColumnType("datetime")
                    .HasColumnName("CREATE_DATE")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.WebpushKey)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("WEBPUSH_KEY");
            });

            modelBuilder.Entity<Newsrealtimenews>(entity =>
            {
                entity.HasKey(e => e.RealtimeId)
                    .HasName("PK_REALTIMENEWS");

                entity.ToTable("NEWSREALTIMENEWS");

                entity.Property(e => e.RealtimeId)
                    .HasColumnName("REALTIME_ID")
                    .HasComment("即時新聞快訊ID");

                entity.Property(e => e.CreateDate)
                    .HasColumnType("datetime")
                    .HasColumnName("CREATE_DATE")
                    .HasDefaultValueSql("(getdate())")
                    .HasComment("新增日期");

                entity.Property(e => e.ModifyDate)
                    .HasColumnType("datetime")
                    .HasColumnName("MODIFY_DATE")
                    .HasDefaultValueSql("(getdate())")
                    .HasComment("修改日期");

                entity.Property(e => e.RealtimeBegdate)
                    .HasColumnType("datetime")
                    .HasColumnName("REALTIME_BEGDATE")
                    .HasDefaultValueSql("(getdate())")
                    .HasComment("上架時間");

                entity.Property(e => e.RealtimeEnddate)
                    .HasColumnType("datetime")
                    .HasColumnName("REALTIME_ENDDATE")
                    .HasDefaultValueSql("(getdate())")
                    .HasComment("下架時間");

                entity.Property(e => e.RealtimeIson)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("REALTIME_ISON")
                    .HasDefaultValueSql("('Y')")
                    .IsFixedLength()
                    .HasComment("Y:啟用;N:不啟用;D:刪除");

                entity.Property(e => e.RealtimeName)
                    .HasMaxLength(48)
                    .HasColumnName("REALTIME_NAME")
                    .HasDefaultValueSql("('')")
                    .HasComment("即時新聞快訊標題");

                entity.Property(e => e.RealtimePush)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("REALTIME_PUSH")
                    .HasDefaultValueSql("('N')")
                    .IsFixedLength()
                    .HasComment("Y:進推播系統;N:否");

                entity.Property(e => e.RealtimeSort)
                    .HasColumnName("REALTIME_SORT")
                    .HasComment("排序");

                entity.Property(e => e.RealtimeSubjectShort)
                    .HasMaxLength(15)
                    .HasColumnName("REALTIME_SUBJECT_SHORT")
                    .HasDefaultValueSql("('')")
                    .HasComment("短標題");

                entity.Property(e => e.RealtimeUrl)
                    .HasMaxLength(200)
                    .HasColumnName("REALTIME_URL")
                    .HasDefaultValueSql("('')")
                    .HasComment("連結網址(新聞ID或外部網址)");

                entity.Property(e => e.UpdateUser)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("UPDATE_USER")
                    .HasDefaultValueSql("('')")
                    .HasComment("更新者");
            });

            modelBuilder.Entity<Newstopic>(entity =>
            {
                entity.HasKey(e => e.TopicId);

                entity.ToTable("NEWSTOPIC");

                entity.Property(e => e.TopicId)
                    .HasColumnName("TOPIC_ID")
                    .HasComment("話題管理ID");

                entity.Property(e => e.CreateDate)
                    .HasColumnType("datetime")
                    .HasColumnName("CREATE_DATE")
                    .HasDefaultValueSql("(getdate())")
                    .HasComment("新增日期");

                entity.Property(e => e.CreateIp)
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasColumnName("CREATE_IP")
                    .HasDefaultValueSql("('')")
                    .HasComment("新增者IP");

                entity.Property(e => e.CreateUser)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("CREATE_USER")
                    .HasDefaultValueSql("('')")
                    .HasComment("新增者對應ADMIN_ID");

                entity.Property(e => e.ModifyDate)
                    .HasColumnType("datetime")
                    .HasColumnName("MODIFY_DATE")
                    .HasDefaultValueSql("(getdate())")
                    .HasComment("修改日期");

                entity.Property(e => e.TopicBegdate)
                    .HasColumnType("datetime")
                    .HasColumnName("TOPIC_BEGDATE")
                    .HasComment("上線時間");

                entity.Property(e => e.TopicCurrent)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("TOPIC_CURRENT")
                    .HasDefaultValueSql("('N')")
                    .IsFixedLength()
                    .HasComment("Y:本期話題;N:否");

                entity.Property(e => e.TopicEnddate)
                    .HasColumnType("datetime")
                    .HasColumnName("TOPIC_ENDDATE")
                    .HasDefaultValueSql("('9999-12-31 23:59:59')");

                entity.Property(e => e.TopicImg)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("TOPIC_IMG")
                    .HasDefaultValueSql("('')")
                    .HasComment("話題圖片(FOR APP)");

                entity.Property(e => e.TopicIson)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("TOPIC_ISON")
                    .HasDefaultValueSql("('N')")
                    .IsFixedLength()
                    .HasComment("Y:啟用;N:不啟用;D:刪除");

                entity.Property(e => e.TopicKeyword)
                    .HasMaxLength(100)
                    .HasColumnName("TOPIC_KEYWORD")
                    .HasDefaultValueSql("('')")
                    .HasComment("其它相關關鍵字");

                entity.Property(e => e.TopicKind)
                    .HasColumnName("TOPIC_KIND")
                    .HasComment("資料型態\r\n1:關鍵字文章\r\n2:外部連結");

                entity.Property(e => e.TopicName)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("TOPIC_NAME")
                    .HasDefaultValueSql("('')")
                    .HasComment("話題名稱");

                entity.Property(e => e.TopicRiderurl)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("TOPIC_RIDERURL")
                    .HasDefaultValueSql("('')")
                    .HasComment("導購網址");

                entity.Property(e => e.TopicSort)
                    .HasColumnName("TOPIC_SORT")
                    .HasComment("話題排序");

                entity.Property(e => e.TopicTop)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("TOPIC_TOP")
                    .HasDefaultValueSql("('N')")
                    .IsFixedLength()
                    .HasComment("Y:顯示首頁;N:否");

                entity.Property(e => e.TopicUrl)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("TOPIC_URL")
                    .HasDefaultValueSql("('')")
                    .HasComment("連結網址");

                entity.Property(e => e.UpdateIp)
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasColumnName("UPDATE_IP")
                    .HasDefaultValueSql("('')")
                    .HasComment("修改者IP");

                entity.Property(e => e.UpdateUser)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("UPDATE_USER")
                    .HasDefaultValueSql("('')")
                    .HasComment("更新者對應ADMIN_ID");
            });

            modelBuilder.Entity<NewstopicKeyword>(entity =>
            {
                entity.HasKey(e => new { e.TopicKeywordId, e.TopicKeyword })
                    .HasName("PK_TOPIC_KEYWORD");

                entity.ToTable("NEWSTOPIC_KEYWORD");

                entity.Property(e => e.TopicKeywordId)
                    .HasColumnName("TOPIC_KEYWORD_ID")
                    .HasComment("對應TOPIC_ID");

                entity.Property(e => e.TopicKeyword)
                    .HasMaxLength(50)
                    .HasColumnName("TOPIC_KEYWORD")
                    .HasDefaultValueSql("('')")
                    .HasComment("相關關鍵字");
            });

            modelBuilder.Entity<NewstopicSub>(entity =>
            {
                entity.HasKey(e => new { e.TopicsubId, e.TopicsubNewsId });

                entity.ToTable("NEWSTOPIC_SUB");

                entity.Property(e => e.TopicsubId)
                    .HasColumnName("TOPICSUB_ID")
                    .HasComment("對應TOPIC ID");

                entity.Property(e => e.TopicsubNewsId)
                    .HasColumnName("TOPICSUB_NEWS_ID")
                    .HasComment("對應新聞NEWS_ID");

                entity.Property(e => e.TopicsubSort)
                    .HasColumnName("TOPICSUB_SORT")
                    .HasComment("前台呈現位置\r\n0:不指定,則照新增日期排序\r\n1:左大圖\r\n2:右1\r\n3:右2\r\n4:右3");
            });

            modelBuilder.Entity<NewsuserReport>(entity =>
            {
                entity.HasKey(e => e.UrreportId);

                entity.ToTable("NEWSUSER_REPORT");

                entity.Property(e => e.UrreportId)
                    .HasColumnName("URREPORT_ID")
                    .HasComment("爆料管理ID");

                entity.Property(e => e.CreateDate)
                    .HasColumnType("datetime")
                    .HasColumnName("CREATE_DATE")
                    .HasDefaultValueSql("(getdate())")
                    .HasComment("新增日期");

                entity.Property(e => e.ModifyDate)
                    .HasColumnType("datetime")
                    .HasColumnName("MODIFY_DATE")
                    .HasDefaultValueSql("(getdate())")
                    .HasComment("修改者日期");

                entity.Property(e => e.UpdateIp)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("UPDATE_IP")
                    .HasDefaultValueSql("('')")
                    .HasComment("修改者IP");

                entity.Property(e => e.UpdateUser)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("UPDATE_USER")
                    .HasDefaultValueSql("('')")
                    .HasComment("更新者對應ADMIN_ID");

                entity.Property(e => e.UrreportDesc)
                    .HasColumnName("URREPORT_DESC")
                    .HasDefaultValueSql("('')")
                    .HasComment("內容");

                entity.Property(e => e.UrreportEmail)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("URREPORT_EMAIL")
                    .HasDefaultValueSql("('')")
                    .HasComment("email");

                entity.Property(e => e.UrreportFile)
                    .HasMaxLength(200)
                    .HasColumnName("URREPORT_FIle")
                    .HasDefaultValueSql("('')")
                    .HasComment("圖片或影片");

                entity.Property(e => e.UrreportIp)
                    .HasMaxLength(60)
                    .IsUnicode(false)
                    .HasColumnName("URREPORT_IP")
                    .HasDefaultValueSql("('')")
                    .HasComment("來源者IP");

                entity.Property(e => e.UrreportPower)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("URREPORT_POWER")
                    .HasDefaultValueSql("('N')")
                    .IsFixedLength()
                    .HasComment("N 表示未處理 , Y 表示已經處理");

                entity.Property(e => e.UrreportSort)
                    .HasColumnName("URREPORT_SORT")
                    .HasComment("排序");

                entity.Property(e => e.UrreportSubject)
                    .HasMaxLength(200)
                    .HasColumnName("URREPORT_SUBJECT")
                    .HasDefaultValueSql("('')")
                    .HasComment("主旨");

                entity.Property(e => e.UrreportTel)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("URREPORT_TEL")
                    .HasDefaultValueSql("('')")
                    .HasComment("電話");

                entity.Property(e => e.UrreportUname)
                    .HasMaxLength(200)
                    .HasColumnName("URREPORT_UNAME")
                    .HasDefaultValueSql("('')")
                    .HasComment("姓名");
            });

            modelBuilder.Entity<NewsvideoChanel>(entity =>
            {
                entity.HasKey(e => e.ChanelId)
                    .HasName("PK_NEWSYOUTUBE_CHANEL");

                entity.ToTable("NEWSVIDEO_CHANEL");

                entity.Property(e => e.ChanelId)
                    .HasColumnName("CHANEL_ID")
                    .HasComment("節目影音ID");

                entity.Property(e => e.ChanelDesc)
                    .HasMaxLength(250)
                    .HasColumnName("CHANEL_DESC")
                    .HasComment("節目簡介");

                entity.Property(e => e.ChanelExName)
                    .HasMaxLength(50)
                    .HasColumnName("CHANEL_EX_NAME")
                    .HasComment("精彩節目首頁延伸按鈕名稱");

                entity.Property(e => e.ChanelExUrl)
                    .HasMaxLength(120)
                    .IsUnicode(false)
                    .HasColumnName("CHANEL_EX_URL")
                    .HasComment("精彩節目首頁延伸網址");

                entity.Property(e => e.ChanelFrontsum)
                    .HasColumnName("CHANEL_FRONTSUM")
                    .HasDefaultValueSql("((6))")
                    .HasComment("前台「影音」預設顯示數量\r\n6 : 12");

                entity.Property(e => e.ChanelImg)
                    .HasMaxLength(70)
                    .IsUnicode(false)
                    .HasColumnName("CHANEL_IMG")
                    .HasDefaultValueSql("('')")
                    .HasComment("節目圖片");

                entity.Property(e => e.ChanelIson)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("CHANEL_ISON")
                    .HasDefaultValueSql("('N')")
                    .IsFixedLength()
                    .HasComment("Y:啟用;N:不啟用;D:刪除");

                entity.Property(e => e.ChanelKind)
                    .HasColumnName("CHANEL_KIND")
                    .HasComment("節目影音清單呈現方式1:直接顯示所有節目的影音;2:另外設定多個分類主題顯示影音");

                entity.Property(e => e.ChanelName)
                    .HasMaxLength(50)
                    .HasColumnName("CHANEL_NAME")
                    .HasDefaultValueSql("('')")
                    .HasComment("節目名稱");

                entity.Property(e => e.ChanelSort)
                    .HasColumnName("CHANEL_SORT")
                    .HasComment("節目排序");

                entity.Property(e => e.ChanelUname)
                    .HasMaxLength(50)
                    .HasColumnName("CHANEL_UNAME")
                    .HasDefaultValueSql("('')")
                    .HasComment("YouTube頻道ID/播放清單ID");

                entity.Property(e => e.ChanelYturl)
                    .HasMaxLength(120)
                    .IsUnicode(false)
                    .HasColumnName("CHANEL_YTURL")
                    .HasDefaultValueSql("('')")
                    .HasComment("節目YT網址");

                entity.Property(e => e.ChanelYturlKind)
                    .HasColumnName("CHANEL_YTURL_KIND")
                    .HasDefaultValueSql("((0))")
                    .HasComment("影片來源型態1.youtube頻道、2.yt播放清單 ");

                entity.Property(e => e.CreateDate)
                    .HasColumnType("datetime")
                    .HasColumnName("CREATE_DATE")
                    .HasDefaultValueSql("(getdate())")
                    .HasComment("新增日期");

                entity.Property(e => e.CreateIp)
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .HasColumnName("CREATE_IP")
                    .HasDefaultValueSql("('')")
                    .HasComment("新增者IP");

                entity.Property(e => e.CreateUser)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("CREATE_USER")
                    .HasDefaultValueSql("('')")
                    .HasComment("新增者");

                entity.Property(e => e.ModifyDate)
                    .HasColumnType("datetime")
                    .HasColumnName("MODIFY_DATE")
                    .HasDefaultValueSql("(getdate())")
                    .HasComment("修改日期");

                entity.Property(e => e.UpdateIp)
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .HasColumnName("UPDATE_IP")
                    .HasDefaultValueSql("('')")
                    .HasComment("更新者IP");

                entity.Property(e => e.UpdateUser)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("UPDATE_USER")
                    .HasDefaultValueSql("('')")
                    .HasComment("更新者");
            });

            modelBuilder.Entity<NewsvideoTopic>(entity =>
            {
                entity.HasKey(e => e.VideoTopicId);

                entity.ToTable("NEWSVIDEO_TOPIC");

                entity.Property(e => e.VideoTopicId)
                    .HasColumnName("VIDEO_TOPIC_ID")
                    .HasComment("影音分類主題ID");

                entity.Property(e => e.ChanelId)
                    .HasColumnName("CHANEL_ID")
                    .HasComment("對應NEWSVIDEO_CHANEL的CHANEL_ID (節目影音ID)");

                entity.Property(e => e.CreateDate)
                    .HasColumnType("datetime")
                    .HasColumnName("CREATE_DATE")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.CreateIp)
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .HasColumnName("CREATE_IP")
                    .HasComment("建立者IP");

                entity.Property(e => e.CreateUser)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("CREATE_USER")
                    .HasComment("建立資料者");

                entity.Property(e => e.ModifyDate)
                    .HasColumnType("datetime")
                    .HasColumnName("MODIFY_DATE")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.UpdateIp)
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .HasColumnName("UPDATE_IP")
                    .HasComment("更新者IP");

                entity.Property(e => e.UpdateUser)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("UPDATE_USER")
                    .HasComment("更新資料者");

                entity.Property(e => e.VideoTopicCode)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("VIDEO_TOPIC_CODE")
                    .HasComment("YouTube頻道ID/播放清單ID");

                entity.Property(e => e.VideoTopicExName)
                    .HasMaxLength(50)
                    .HasColumnName("VIDEO_TOPIC_EX_NAME")
                    .HasComment("分類主題影音延伸按鈕名稱");

                entity.Property(e => e.VideoTopicExUrl)
                    .HasMaxLength(120)
                    .IsUnicode(false)
                    .HasColumnName("VIDEO_TOPIC_EX_URL")
                    .HasComment("分類主題影音延伸網址");

                entity.Property(e => e.VideoTopicIson)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("VIDEO_TOPIC_ISON")
                    .IsFixedLength()
                    .HasComment("分類主題影音狀態 Y:有效 N:下檔 D:刪除");

                entity.Property(e => e.VideoTopicName)
                    .HasMaxLength(50)
                    .HasColumnName("VIDEO_TOPIC_NAME")
                    .HasComment("分類主題影音名稱");

                entity.Property(e => e.VideoTopicSort)
                    .HasColumnName("VIDEO_TOPIC_SORT")
                    .HasComment("分類主題影音排序");

                entity.Property(e => e.VideoTopicType)
                    .HasColumnName("VIDEO_TOPIC_TYPE")
                    .HasComment("分類主題影片來源型態1.youtube頻道、2.yt播放清單 ");
            });

            modelBuilder.Entity<Newsvoice>(entity =>
            {
                entity.HasKey(e => e.VoiceNewsId);

                entity.ToTable("NEWSVOICE");

                entity.Property(e => e.VoiceNewsId)
                    .ValueGeneratedNever()
                    .HasColumnName("VOICE_NEWS_ID")
                    .HasComment("對應新聞NEWS_ID");

                entity.Property(e => e.CreateDate)
                    .HasColumnType("datetime")
                    .HasColumnName("CREATE_DATE")
                    .HasDefaultValueSql("(getdate())")
                    .HasComment("新增日期");

                entity.Property(e => e.VoiceIson)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("VOICE_ISON")
                    .IsFixedLength()
                    .HasComment("MP3上傳狀態Y:完成;N:否");
            });

            modelBuilder.Entity<Newsyoutube>(entity =>
            {
                entity.HasKey(e => e.YoutubeVideoId);

                entity.ToTable("NEWSYOUTUBE");

                entity.Property(e => e.YoutubeVideoId)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("YOUTUBE_VIDEO_ID")
                    .HasComment("精彩節目清單YOUTUBE ID");

                entity.Property(e => e.ModifyDate)
                    .HasColumnType("datetime")
                    .HasColumnName("MODIFY_DATE")
                    .HasDefaultValueSql("(getdate())")
                    .HasComment("修改日期");

                entity.Property(e => e.UpdateUser)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("UPDATE_USER")
                    .HasDefaultValueSql("('')")
                    .HasComment("更新者");

                entity.Property(e => e.Videolen)
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .HasColumnName("VIDEOLEN")
                    .HasDefaultValueSql("((0))")
                    .HasComment("影片長度");

                entity.Property(e => e.ViewCount)
                    .HasColumnType("numeric(20, 0)")
                    .HasColumnName("VIEW_COUNT")
                    .HasComment("影片瀏覽次數");

                entity.Property(e => e.YoutubeCategory)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("YOUTUBE_CATEGORY")
                    .HasDefaultValueSql("('')")
                    .HasComment("YOUTUBE分類");

                entity.Property(e => e.YoutubeChanelId)
                    .HasColumnName("YOUTUBE_CHANEL_ID")
                    .HasComment("對應節目頻道CHANEL_ID");

                entity.Property(e => e.YoutubeDesc)
                    .HasColumnName("YOUTUBE_DESC")
                    .HasDefaultValueSql("('')")
                    .HasComment("YOUTUBE說明");

                entity.Property(e => e.YoutubeImg)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("YOUTUBE_IMG")
                    .HasDefaultValueSql("('')")
                    .HasComment("YOUTUBE圖片");

                entity.Property(e => e.YoutubeIson)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("YOUTUBE_ISON")
                    .HasDefaultValueSql("('Y')")
                    .IsFixedLength()
                    .HasComment("Y:啟用;N:不啟用;D:刪除");

                entity.Property(e => e.YoutubePublishedDate)
                    .HasColumnType("datetime")
                    .HasColumnName("YOUTUBE_PUBLISHED_DATE")
                    .HasDefaultValueSql("('')")
                    .HasComment("YOUTUBE發布時間");

                entity.Property(e => e.YoutubeTitle)
                    .HasMaxLength(200)
                    .HasColumnName("YOUTUBE_TITLE")
                    .HasDefaultValueSql("('')")
                    .HasComment("YOUTUBE標題");

                entity.Property(e => e.YoutubeTopicId).HasColumnName("YOUTUBE_TOPIC_ID");
            });

            modelBuilder.Entity<NewsyoutubeLatest>(entity =>
            {
                entity.HasKey(e => e.YoutubeVideoId)
                    .HasName("PK_NewsYoutube_Latest");

                entity.ToTable("NEWSYOUTUBE_LATEST");

                entity.Property(e => e.YoutubeVideoId)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("YOUTUBE_VIDEO_ID")
                    .HasComment("精彩節目清單YOUTUBE ID");

                entity.Property(e => e.ModifyDate)
                    .HasColumnType("datetime")
                    .HasColumnName("MODIFY_DATE")
                    .HasDefaultValueSql("(getdate())")
                    .HasComment("修改日期");

                entity.Property(e => e.UpdateUser)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("UPDATE_USER")
                    .HasDefaultValueSql("('')")
                    .HasComment("更新者");

                entity.Property(e => e.Videolen)
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .HasColumnName("VIDEOLEN")
                    .HasDefaultValueSql("((0))")
                    .HasComment("影片長度");

                entity.Property(e => e.ViewCount)
                    .HasColumnType("numeric(20, 0)")
                    .HasColumnName("VIEW_COUNT")
                    .HasComment("影片瀏覽次數");

                entity.Property(e => e.YoutubeCategory)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("YOUTUBE_CATEGORY")
                    .HasDefaultValueSql("('')")
                    .HasComment("YOUTUBE分類");

                entity.Property(e => e.YoutubeChanelId)
                    .HasColumnName("YOUTUBE_CHANEL_ID")
                    .HasComment("對應節目頻道CHANEL_ID");

                entity.Property(e => e.YoutubeDesc)
                    .HasColumnName("YOUTUBE_DESC")
                    .HasDefaultValueSql("('')")
                    .HasComment("YOUTUBE說明");

                entity.Property(e => e.YoutubeImg)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("YOUTUBE_IMG")
                    .HasDefaultValueSql("('')")
                    .HasComment("YOUTUBE圖片");

                entity.Property(e => e.YoutubePublishedDate)
                    .HasColumnType("datetime")
                    .HasColumnName("YOUTUBE_PUBLISHED_DATE")
                    .HasDefaultValueSql("('')")
                    .HasComment("YOUTUBE發布時間");

                entity.Property(e => e.YoutubeTitle)
                    .HasMaxLength(200)
                    .HasColumnName("YOUTUBE_TITLE")
                    .HasDefaultValueSql("('')")
                    .HasComment("YOUTUBE標題");

                entity.Property(e => e.YoutubeTopicId).HasColumnName("YOUTUBE_TOPIC_ID");
            });

            modelBuilder.Entity<Newsyoutubeviewct>(entity =>
            {
                entity.HasKey(e => e.YoutubevcId);

                entity.ToTable("NEWSYOUTUBEVIEWCT");

                entity.Property(e => e.YoutubevcId)
                    .HasColumnName("YOUTUBEVC_ID")
                    .HasComment("YOUTUBE觀看次數記錄ID");

                entity.Property(e => e.YoutubevcChanelId)
                    .HasColumnName("YOUTUBEVC_CHANEL_ID")
                    .HasComment("對應節目頻道CHANEL_ID");

                entity.Property(e => e.YoutubevcDate)
                    .HasColumnType("date")
                    .HasColumnName("YOUTUBEVC_DATE")
                    .HasDefaultValueSql("(getdate())")
                    .HasComment("新增日期");

                entity.Property(e => e.YoutubevcVcount)
                    .HasColumnType("numeric(20, 0)")
                    .HasColumnName("YOUTUBEVC_VCOUNT")
                    .HasComment("觀看次數");

                entity.Property(e => e.YoutubevcVideoId)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("YOUTUBEVC_VIDEO_ID")
                    .HasDefaultValueSql("('')")
                    .HasComment("YOUTUBE ID");
            });

            modelBuilder.Entity<TrCategory>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("tr_category");

                entity.Property(e => e.Categoryename)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("categoryename");

                entity.Property(e => e.Categoryname)
                    .HasMaxLength(20)
                    .HasColumnName("categoryname");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
