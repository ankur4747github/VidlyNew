namespace VidlyNew.Migrations
{
    using System.Data.Entity.Migrations;

    public partial class SeedUsers : DbMigration
    {
        public override void Up()
        {
            Sql(@"
                INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'1ab24018-9d1b-4617-90b1-b7a2be48e6d1', N'Admin@vidly.com', 0, N'AFFa7weKFSU1HpS1ffVHow1nExZ2Yrvw+VOiTgnxQrOBmelIAX3zSJcwDaT4dHJYPg==', N'ffe3a50f-29f8-429e-8f03-6fce55e6068e', NULL, 0, 0, NULL, 1, 0, N'Admin@vidly.com')
                INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'39bf2106-e692-47a5-83a9-b659d8635d91', N'gues@vidly.com', 0, N'ANkHk1rSKyIDI4/aSy2OjWD3KzA44ZBkeR20HeuFL+gXU9dKjaN4t7iGgaGPhyyigw==', N'8951227d-1198-4cd3-9f00-6bb67931ccf6', NULL, 0, 0, NULL, 1, 0, N'gues@vidly.com')

                INSERT INTO [dbo].[AspNetRoles] ([Id], [Name]) VALUES (N'dabe7095-6dff-41af-b414-72a9b2741d5b', N'CanManageMovies')

                INSERT INTO [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'1ab24018-9d1b-4617-90b1-b7a2be48e6d1', N'dabe7095-6dff-41af-b414-72a9b2741d5b')
               ");
        }

        public override void Down()
        {
        }
    }
}