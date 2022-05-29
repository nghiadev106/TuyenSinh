using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace TuyenSinh.Model
{
    public partial class tuyensinhContext : DbContext
    {
        public tuyensinhContext()
        {
        }

        public tuyensinhContext(DbContextOptions<tuyensinhContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Ability> Abilities { get; set; }
        public virtual DbSet<AspNetRole> AspNetRoles { get; set; }
        public virtual DbSet<AspNetRoleClaim> AspNetRoleClaims { get; set; }
        public virtual DbSet<AspNetUser> AspNetUsers { get; set; }
        public virtual DbSet<AspNetUserClaim> AspNetUserClaims { get; set; }
        public virtual DbSet<AspNetUserLogin> AspNetUserLogins { get; set; }
        public virtual DbSet<AspNetUserRole> AspNetUserRoles { get; set; }
        public virtual DbSet<AspNetUserToken> AspNetUserTokens { get; set; }
        public virtual DbSet<Category> Categories { get; set; }
        public virtual DbSet<Combination> Combinations { get; set; }
        public virtual DbSet<Conduct> Conducts { get; set; }
        public virtual DbSet<ContactInfo> ContactInfos { get; set; }
        public virtual DbSet<District> Districts { get; set; }
        public virtual DbSet<InfoThpt> InfoThpts { get; set; }
        public virtual DbSet<Major> Majors { get; set; }
        public virtual DbSet<Nation> Nations { get; set; }
        public virtual DbSet<News> News { get; set; }
        public virtual DbSet<Province> Provinces { get; set; }
        public virtual DbSet<Question> Questions { get; set; }
        public virtual DbSet<School> Schools { get; set; }
        public virtual DbSet<Student> Students { get; set; }
        public virtual DbSet<SubjectTo> SubjectTos { get; set; }
        public virtual DbSet<Ward> Wards { get; set; }
        public virtual DbSet<Wish> Wishes { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer(@"Server=DESKTOP-7G2VCHR;Database=tuyensinh;Trusted_Connection=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "SQL_Latin1_General_CP1_CI_AS");

            modelBuilder.Entity<Ability>(entity =>
            {
                entity.ToTable("Ability");

                entity.Property(e => e.Name).HasMaxLength(50);
            });

            modelBuilder.Entity<AspNetRole>(entity =>
            {
                entity.Property(e => e.Name).HasMaxLength(256);

                entity.Property(e => e.NormalizedName).HasMaxLength(256);
            });

            modelBuilder.Entity<AspNetRoleClaim>(entity =>
            {
                entity.Property(e => e.RoleId)
                    .IsRequired()
                    .HasMaxLength(450);

                entity.HasOne(d => d.Role)
                    .WithMany(p => p.AspNetRoleClaims)
                    .HasForeignKey(d => d.RoleId);
            });

            modelBuilder.Entity<AspNetUser>(entity =>
            {
                entity.Property(e => e.Email).HasMaxLength(256);

                entity.Property(e => e.NormalizedEmail).HasMaxLength(256);

                entity.Property(e => e.NormalizedUserName).HasMaxLength(256);

                entity.Property(e => e.UserName).HasMaxLength(256);
            });

            modelBuilder.Entity<AspNetUserClaim>(entity =>
            {
                entity.Property(e => e.UserId)
                    .IsRequired()
                    .HasMaxLength(450);

                entity.HasOne(d => d.User)
                    .WithMany(p => p.AspNetUserClaims)
                    .HasForeignKey(d => d.UserId);
            });

            modelBuilder.Entity<AspNetUserLogin>(entity =>
            {
                entity.HasKey(e => new { e.LoginProvider, e.ProviderKey });

                entity.Property(e => e.UserId)
                    .IsRequired()
                    .HasMaxLength(450);

                entity.HasOne(d => d.User)
                    .WithMany(p => p.AspNetUserLogins)
                    .HasForeignKey(d => d.UserId);
            });

            modelBuilder.Entity<AspNetUserRole>(entity =>
            {
                entity.HasKey(e => new { e.UserId, e.RoleId });

                entity.HasOne(d => d.Role)
                    .WithMany(p => p.AspNetUserRoles)
                    .HasForeignKey(d => d.RoleId);

                entity.HasOne(d => d.User)
                    .WithMany(p => p.AspNetUserRoles)
                    .HasForeignKey(d => d.UserId);
            });

            modelBuilder.Entity<AspNetUserToken>(entity =>
            {
                entity.HasKey(e => new { e.UserId, e.LoginProvider, e.Name });

                entity.HasOne(d => d.User)
                    .WithMany(p => p.AspNetUserTokens)
                    .HasForeignKey(d => d.UserId);
            });

            modelBuilder.Entity<Category>(entity =>
            {
                entity.ToTable("Category");

                entity.Property(e => e.CreateDate).HasColumnType("datetime");

                entity.Property(e => e.Description).HasMaxLength(500);

                entity.Property(e => e.Name).HasMaxLength(500);

                entity.Property(e => e.Url).HasMaxLength(500);
            });

            modelBuilder.Entity<Combination>(entity =>
            {
                entity.ToTable("Combination");

                entity.Property(e => e.Name).HasMaxLength(250);
            });

            modelBuilder.Entity<Conduct>(entity =>
            {
                entity.ToTable("Conduct");

                entity.Property(e => e.Name).HasMaxLength(50);
            });

            modelBuilder.Entity<ContactInfo>(entity =>
            {
                entity.ToTable("ContactInfo");

                entity.Property(e => e.Address).HasMaxLength(500);

                entity.Property(e => e.Bhyt).HasColumnName("BHYT");

                entity.Property(e => e.Name).HasMaxLength(500);

                entity.HasOne(d => d.Student)
                    .WithMany(p => p.ContactInfos)
                    .HasForeignKey(d => d.StudentId)
                    .HasConstraintName("FK_ContactInfo_Student");

                entity.HasOne(d => d.SubjectTo)
                    .WithMany(p => p.ContactInfos)
                    .HasForeignKey(d => d.SubjectToId)
                    .HasConstraintName("FK_ContactInfo_SubjectTo");
            });

            modelBuilder.Entity<District>(entity =>
            {
                entity.ToTable("District");

                entity.Property(e => e.Name).HasMaxLength(500);

                entity.HasOne(d => d.Province)
                    .WithMany(p => p.Districts)
                    .HasForeignKey(d => d.ProvinceId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_District_Province");
            });

            modelBuilder.Entity<InfoThpt>(entity =>
            {
                entity.ToTable("InfoTHPT");

                entity.Property(e => e.Graduation).HasMaxLength(500);

                entity.Property(e => e.Point).HasMaxLength(10);
                entity.Property(e => e.Math).HasMaxLength(10);
                entity.Property(e => e.Literature).HasMaxLength(10);

                entity.Property(e => e.English).HasMaxLength(10);
                entity.Property(e => e.Biology).HasMaxLength(10);
                entity.Property(e => e.Geography).HasMaxLength(10);
                entity.Property(e => e.Chemistry).HasMaxLength(10);
                entity.Property(e => e.History).HasMaxLength(10);
                entity.Property(e => e.Physics).HasMaxLength(10);

                entity.Property(e => e.Hsddkxt)
                    .HasMaxLength(50)
                    .HasColumnName("HSDDKXT");

                entity.Property(e => e.Sbd)
                    .HasMaxLength(50)
                    .HasColumnName("SBD");

                entity.Property(e => e.ScoreCard).HasMaxLength(500);

                entity.HasOne(d => d.Ability)
                    .WithMany(p => p.InfoThpts)
                    .HasForeignKey(d => d.AbilityId)
                    .HasConstraintName("FK_InfoTHPT_Ability");

                entity.HasOne(d => d.Conduct)
                    .WithMany(p => p.InfoThpts)
                    .HasForeignKey(d => d.ConductId)
                    .HasConstraintName("FK_InfoTHPT_Conduct");

                entity.HasOne(d => d.Province10)
                    .WithMany(p => p.InfoThpts)
                    .HasForeignKey(d => d.Province10Id)
                    .HasConstraintName("FK_InfoTHPT_Province");

                entity.HasOne(d => d.School10)
                    .WithMany(p => p.InfoThpts)
                    .HasForeignKey(d => d.School10Id)
                    .HasConstraintName("FK_InfoTHPT_School");

                entity.HasOne(d => d.Student)
                    .WithMany(p => p.InfoThpts)
                    .HasForeignKey(d => d.StudentId)
                    .HasConstraintName("FK_InfoTHPT_Student");
            });

            modelBuilder.Entity<Major>(entity =>
            {
                entity.ToTable("Major");

                entity.Property(e => e.Code).HasMaxLength(100);

                entity.Property(e => e.CreateDate).HasColumnType("datetime");

                entity.Property(e => e.Description).HasMaxLength(500);

                entity.Property(e => e.EditDate).HasColumnType("datetime");

                entity.Property(e => e.Name).HasMaxLength(500);
            });

            modelBuilder.Entity<Nation>(entity =>
            {
                entity.ToTable("Nation");

                entity.Property(e => e.Name).HasMaxLength(250);
            });

            modelBuilder.Entity<News>(entity =>
            {
                entity.Property(e => e.CreateDate).HasColumnType("datetime");

                entity.Property(e => e.EditDate).HasColumnType("datetime");

                entity.Property(e => e.Image).HasMaxLength(500);

                entity.Property(e => e.Name).HasMaxLength(500);

                entity.Property(e => e.Url).HasMaxLength(250);

                entity.HasOne(d => d.Category)
                    .WithMany(p => p.News)
                    .HasForeignKey(d => d.CategoryId)
                    .HasConstraintName("FK_News_Category");
            });

            modelBuilder.Entity<Province>(entity =>
            {
                entity.ToTable("Province");

                entity.Property(e => e.Code)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Name).HasMaxLength(500);
            });

            modelBuilder.Entity<Question>(entity =>
            {
                entity.ToTable("Question");

                entity.Property(e => e.CreateDate).HasColumnType("datetime");

                entity.Property(e => e.EditDate).HasColumnType("datetime");

                entity.Property(e => e.Image).HasMaxLength(500);

                entity.Property(e => e.Name).HasMaxLength(500);

                entity.Property(e => e.Url).HasMaxLength(250);
            });

            modelBuilder.Entity<School>(entity =>
            {
                entity.ToTable("School");

                entity.Property(e => e.Name).HasMaxLength(500);
            });

            modelBuilder.Entity<Student>(entity =>
            {
                entity.ToTable("Student");

                entity.Property(e => e.Address)
                    .IsRequired()
                    .HasMaxLength(250);

                entity.Property(e => e.Avatar).HasMaxLength(250);

                entity.Property(e => e.Cmnd).HasColumnName("CMND");

                entity.Property(e => e.CreateDate).HasColumnType("datetime");

                entity.Property(e => e.Dob)
                    .HasColumnType("datetime")
                    .HasColumnName("DOB");

                entity.Property(e => e.EditDate).HasColumnType("datetime");

                entity.Property(e => e.Email)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(250);

                entity.Property(e => e.Phone)
                    .IsRequired()
                    .HasMaxLength(11)
                    .IsUnicode(false);

                entity.HasOne(d => d.Nation)
                    .WithMany(p => p.Students)
                    .HasForeignKey(d => d.NationId)
                    .HasConstraintName("FK_Student_Nation");
            });

            modelBuilder.Entity<SubjectTo>(entity =>
            {
                entity.ToTable("SubjectTo");

                entity.Property(e => e.Name).HasMaxLength(250);
            });

            modelBuilder.Entity<Ward>(entity =>
            {
                entity.ToTable("Ward");

                entity.Property(e => e.Name).HasMaxLength(500);

                entity.HasOne(d => d.District)
                    .WithMany(p => p.Wards)
                    .HasForeignKey(d => d.DistrictId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Ward_District");
            });

            modelBuilder.Entity<Wish>(entity =>
            {
                entity.ToTable("Wish");
                entity.Property(e => e.Point1).HasMaxLength(10);
                entity.Property(e => e.Point2).HasMaxLength(10);

                entity.HasOne(d => d.Combination1)
                    .WithMany(p => p.Wishes)
                    .HasForeignKey(d => d.Combination1Id)
                    .HasConstraintName("FK_Wish_Combination");

                entity.HasOne(d => d.Major1)
                    .WithMany(p => p.Wishes)
                    .HasForeignKey(d => d.Major1Id)
                    .HasConstraintName("FK_Wish_Major");

                entity.HasOne(d => d.Student)
                    .WithMany(p => p.Wishes)
                    .HasForeignKey(d => d.StudentId)
                    .HasConstraintName("FK_Wish_Student");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
