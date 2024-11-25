namespace BaseballPipeline.Server.Data
{
    using BaseballPipeline.Server.Data.Entities;
    using Microsoft.EntityFrameworkCore;

    public class AppDBContext: DbContext
    {
        public AppDBContext(DbContextOptions<AppDBContext> options) : base(options)
        {
        }

        public DbSet<Comment> Comments { get; set; }
        public DbSet<Entry> Entries { get; set; }
        public DbSet<Tag> Tags { get; set; }
        public DbSet<EntryTag> EntriesTags { get; set; }
        // public DbSet<NotificationSubscription> NotificationSubscriptions { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<EntryTag>()
                .HasKey(et => new { et.EntryId, et.TagId });

            //Seed Data

            /* string adminRoleGUID = "d92395eb-522f-4cae-8757-44a842f08f4d";
            string adminUserGUID = "2c628407-1e98-46ee-a196-4ef5ea9b5073";
            string adminConcurrencyGUID = "fb273bfb-f681-454f-8672-892bfb56381d";
            string adminSecurityGUID = "4bac4478-9330-486d-b0fd-9468d3fe0043";
            string userUserGUID = "8b3ced07-8881-445f-bb48-1ff5e2c2db41";

            modelBuilder.Entity<IdentityRole>().HasData(new IdentityRole { Name = "User", NormalizedName = "USER", Id = userUserGUID, ConcurrencyStamp = Guid.NewGuid().ToString() });
            modelBuilder.Entity<IdentityRole>().HasData(new IdentityRole { Name = "Admin", NormalizedName = "ADMIN", Id = adminRoleGUID, ConcurrencyStamp = Guid.NewGuid().ToString() });

            modelBuilder.Entity<ApplicationUser>().HasData(new ApplicationUser
            {
                Id = adminUserGUID,
                AccessFailedCount = 0,
                PasswordHash = "AQAAAAEAACcQAAAAEGpFYfHRZyc5lir+Y/oFS6AtlV3lVv/4p3AK4+X3Jrnp7wggjr4fALYjwv5LtQMdoQ==",
                LockoutEnabled = true,
                UserName = "andrewsalmela@gmail.com",
                Email = "andrewsalmela@gmail.com",
                EmailConfirmed = true,
                NormalizedEmail = "ANDREWSALMELA@GMAIL.COM",
                NormalizedUserName = "ANDREWSALMELA@GMAIL.COM",
                SecurityStamp = adminSecurityGUID,
                ConcurrencyStamp = adminConcurrencyGUID,
                TwoFactorEnabled = false,
                PhoneNumber = null,
                PhoneNumberConfirmed = false
            });

            modelBuilder.Entity<IdentityUserRole<string>>().HasData(new IdentityUserRole<string>() { RoleId = adminRoleGUID, UserId = adminUserGUID });

            modelBuilder.Entity<Tag>().HasData(new Tag { TagId = 1, Value = "Hitting" });
            modelBuilder.Entity<Tag>().HasData(new Tag { TagId = 2, Value = "Pitching" });
            modelBuilder.Entity<Tag>().HasData(new Tag { TagId = 3, Value = "Infield" });
            modelBuilder.Entity<Tag>().HasData(new Tag { TagId = 4, Value = "Outfield" });
            modelBuilder.Entity<Tag>().HasData(new Tag { TagId = 5, Value = "Catching" });
            modelBuilder.Entity<Tag>().HasData(new Tag { TagId = 6, Value = "Right-Handed" });
            modelBuilder.Entity<Tag>().HasData(new Tag { TagId = 7, Value = "Left-Handed" }); */
        }
    }
}
