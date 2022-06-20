namespace GestiuneBileteAvion.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class adaugareUseri : DbMigration
    {
        public override void Up()
        {
            Sql(@"
INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'898b73f3-bce0-480b-a536-8b2bc1c78801', N'admin@bil.ro', 0, N'ADKrgSqE7p4RVERsk1ZfhBGl2UKr53VODxJte/ZMVv3GFst4OWObAlijpB3g9HOzxg==', N'cb234e9f-fc4b-4262-a0f2-3de9b93bc09d', NULL, 0, 0, NULL, 1, 0, N'admin@bil.ro')
INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'b8d29fca-d4fc-4e1f-b13b-941a166376df', N'guest@guest.com', 0, N'AIOWZQS/Uzoij+ohEIItybNZUEPf8vIJukVH0lw07uH1Ij98CVEs0GXUBvuZKeFQUg==', N'a7729370-9642-45b7-8311-0e943361bbf2', NULL, 0, 0, NULL, 1, 0, N'guest@guest.com')

INSERT INTO [dbo].[AspNetRoles] ([Id], [Name]) VALUES (N'b9707ea5-6870-4bb2-a883-40684dcbb3cf', N'ManagerAdaugareSiModificare')

INSERT INTO [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'898b73f3-bce0-480b-a536-8b2bc1c78801', N'b9707ea5-6870-4bb2-a883-40684dcbb3cf')

");
        }
        
        public override void Down()
        {
        }
    }
}
