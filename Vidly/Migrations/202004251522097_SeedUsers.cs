namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SeedUsers : DbMigration
    {
        public override void Up()
        {
            Sql(@"
INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'd9269f9b-0483-455b-8244-cd7c3392a1ec', N'guest@vidly.com', 0, N'ACrZJ+6eCtT/ZkVxnLsTl/5ppkPS1li/zPxZb+wizYKYuZ6SJTcYYbvmO9p9hu/PJw==', N'ed7390d3-c875-457f-93b1-0653eb817276', NULL, 0, 0, NULL, 1, 0, N'guest@vidly.com')
INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'ebbbec7f-f877-4582-ab89-e0c748b16b47', N'admin@vidly.com', 0, N'APjFJkA7G88GsybfaLRV1PUm3wnmhc1W8nputiJ3zvq+I+QJD4CljYkU1hYiGKsCDw==', N'dd4f5c67-8c27-498d-80ce-e3ca28e4ff92', NULL, 0, 0, NULL, 1, 0, N'admin@vidly.com')

INSERT INTO [dbo].[AspNetRoles] ([Id], [Name]) VALUES (N'96f3ae40-4fee-4ea5-b466-1694b1e27f3e', N'CanManageMovies')

INSERT INTO [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'ebbbec7f-f877-4582-ab89-e0c748b16b47', N'96f3ae40-4fee-4ea5-b466-1694b1e27f3e')

");
        }
        
        public override void Down()
        {
        }
    }
}
